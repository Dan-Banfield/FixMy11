using System.Linq;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading.Tasks;
using FixMy11.Features.Privacy;
using System.Collections.Generic;

namespace FixMy11.Forms
{
    public partial class MainForm : Form
    {
        private List<TreeNodeFeaturePair> nodeFeaturePairs = new List<TreeNodeFeaturePair>();

        public MainForm()
        {
            InitializeComponent();
            PopulateTreeView();
        }

        #region Event Handlers

        #region Link Label

        private void sourceCodeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => Process.Start("https://github.com/Dan-Banfield/FixMy11");

        #endregion

        #region Tree View

        private void treeView_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown)
            {
                CheckAllChildNodes(e.Node, e.Node.Checked);

                if (e.Node.Checked == false && e.Node.Parent != null)
                    e.Node.Parent.Checked = false;

                if (e.Node.Parent != null)
                    e.Node.Parent.Checked = e.Node.Parent.Nodes.Cast<TreeNode>().All(n => n.Checked);
            }
        }

        private void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.Checked = nodeChecked;
                if (node.Nodes.Count > 0)
                {
                    CheckAllChildNodes(node, nodeChecked);
                }
            }
        }

        #endregion

        #region Buttons

        private async void applySelectedFixesButton_Click(object sender, System.EventArgs e)
        {
            int fixCount = GetSelectedFeatureCount();

            if (fixCount <= 0)
            {
                MessageBoxHelper.ShowError("You must select at least one thing to fix!");
                return;
            }

            Hide();
            Logger.Instance.ShowLogForm();
            foreach (TreeNodeFeaturePair pair in nodeFeaturePairs)
            {
                if (pair.TreeNode.Checked)
                    await Task.Run(() => pair.Feature.DoFeature());
            }

            PromptRestart();
        }

        #endregion

        #endregion

        #region Methods

        private int GetSelectedFeatureCount()
        {
            int count = 0;
            foreach (TreeNodeFeaturePair pair in nodeFeaturePairs)
            {
                if (pair.TreeNode.Checked)
                    count++;
            }
            return count;
        }

        private void PopulateTreeView()
        {
            AddPrivacyFeatureNodes();
        }

        private void AddPrivacyFeatureNodes()
        {
            //Create privacy parent node for organisation.

            TreeNode privacyNode = new TreeNode("Privacy");
            treeView.Nodes.Add(privacyNode);

            #region Privacy Feature Nodes

            TreeNode diagnosticDataTreeNode = new TreeNode("Disable Diagnostic Data Collection");
            nodeFeaturePairs.Add(new TreeNodeFeaturePair() { TreeNode = diagnosticDataTreeNode, Feature = DiagnosticData.Instance } );

            TreeNode locationTrackingTreeNode = new TreeNode("Disable Location Tracking");
            nodeFeaturePairs.Add(new TreeNodeFeaturePair() { TreeNode = locationTrackingTreeNode, Feature = LocationTracking.Instance });

            TreeNode advertisingIDTreeNode = new TreeNode("Disable Advertising ID");
            nodeFeaturePairs.Add(new TreeNodeFeaturePair() { TreeNode = advertisingIDTreeNode, Feature = AdvertisingID.Instance });

            #endregion

            privacyNode.Nodes.Add(diagnosticDataTreeNode);
            privacyNode.Nodes.Add(locationTrackingTreeNode);
            privacyNode.Nodes.Add(advertisingIDTreeNode);
        }

        private void PromptRestart()
        {
            if (MessageBoxHelper.AskQuestion("It is highly recommended to restart your PC after making changes like these. Would you like to do so now?") == DialogResult.Yes)
                RestartPC();
        }

        private void RestartPC() => Process.Start("shutdown", "/r /t 0");

        #endregion
    }
}