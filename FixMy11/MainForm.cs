using System.Linq;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading.Tasks;
using FixMy11.Features.Privacy;
using System.Collections.Generic;

namespace FixMy11
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
            int fixCount = 0;

            foreach (TreeNodeFeaturePair pair in nodeFeaturePairs)
            {
                if (pair.TreeNode.Checked)
                {
                    await Task.Run(() => 
                    {
                        pair.Feature.DoFeature();
                    });
                    fixCount++;
                }
            }

            if (fixCount <= 0)
                MessageBoxHelper.ShowError("You must select at least one thing to fix!");
        }

        #endregion

        #endregion

        #region Methods

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

            #endregion

            privacyNode.Nodes.Add(diagnosticDataTreeNode);
        }

        #endregion
    }
}