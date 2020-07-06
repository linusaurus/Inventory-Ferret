using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using DataLayer.Entities;
using DataLayer.Services;
using System.Runtime.Remoting.Contexts;
using Microsoft.EntityFrameworkCore;
using Dapper;

namespace Weaselware.InventoryFerret.UserControls
{
    public partial class PartTypePicker : UserControl
    {
        private BadgerDataModel ctx;
        PartsService _partService;
        private int selectedCategory;
        private int selectedPartType;

        public int SelectedCategory
        {
            get { return selectedCategory; }
            set
            {
                selectedCategory = value;

            }
        }

        public int SelectedPartType
        {
            get { return selectedPartType; }
            set { selectedPartType = value;}
        }

        //---------------Events------------------------

        public delegate void CategorySelectedHandler(object sender, CategorySelectedEventArgs e);
        public delegate void PartTypeSelectedHandler(object sender, PartTypeSelectedEventArgs e);

        public event CategorySelectedHandler OnCategorySelected;
        public event PartTypeSelectedHandler OnPartTypeSelected;

        public class CategorySelectedEventArgs : EventArgs
        {
            public int CategoryID { get; set; }

        }

        public class PartTypeSelectedEventArgs : EventArgs
        {
            public int PartTypeID { get; set; }
        }
  
        //---------------------------------------------

        public PartTypePicker()
        {
            InitializeComponent();
        }

        public void SetContext(BadgerDataModel context)
        {
            ctx = context;
            _partService = new PartsService(ctx);
            tvPartTypes.AfterSelect += TvPartTypes_AfterSelect;
            LoadTree();
        }

        private void TvPartTypes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is PartCategory)
            {             
                selectedCategory = ((PartCategory)e.Node.Tag).PartCategoryID;

                if (OnCategorySelected != null)
                {
                    OnCategorySelected(this, new CategorySelectedEventArgs { CategoryID = selectedCategory});
                }

            }
            else if (e.Node.Tag is PartTypes)
            {              
                selectedPartType = ((PartTypes)e.Node.Tag).PartTypeID;
                if (OnPartTypeSelected != null)
                {
                    OnPartTypeSelected(this, new PartTypeSelectedEventArgs { PartTypeID = selectedPartType });
                }
            }
            
        }

        private void LoadTree()
        {
            var categories = _partService.GetPartCategories();

            TreeNode tnode = new TreeNode("Part Types");
            tvPartTypes.Nodes.Add(tnode);

            foreach (var citem in categories)
            {
                TreeNode pNode = new TreeNode(citem.PartCategoryName);
                pNode.Tag = citem;
                tnode.Nodes.Add(pNode);
                foreach (var item in citem.PartTypes)
                {
                    TreeNode tNode = new TreeNode(item.PartTypeName);
                    tNode.Tag= item;
                    pNode.Nodes.Add(tNode);
                }
            }
            tnode.Expand();
        }

        private void PartTypePicker_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}
