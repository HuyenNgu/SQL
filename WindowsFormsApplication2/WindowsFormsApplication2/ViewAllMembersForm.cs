using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class ViewAllMembersForm : Form
    {
        public ViewAllMembersForm()
        {
            InitializeComponent();
            this.Load += ViewAllMembers_Load;
        }

        private void ViewAllMembers_Load(object sender, EventArgs e)
        {
            this.ViewAllMembers();
        }
        private void ViewAllMembers()
        {
            var db = new OOPCSEntities();
            var members = db.Members.ToArray();
            var memberViews = new MemberView[members.Length];
            for (int i = 0; i < members.Length;i++)
            {
                memberViews[i] = new MemberView(members[i]);
            }
            this.grdMembers.DataSource = members;
        }
    }
}
