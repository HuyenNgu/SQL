using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class MemberView
    {
        public MemberView(Member member){
            this.id = member.id;
            this.Fullname = member.Fullname;
            this.Gender = member.Gender == true ? "Nam" : "Nữ"; //đúng la nam, ngược lại là nữ
            if (member.Birthday != null)
                this.Birthday = String.Format("{0}/{1}/{2}", 
                    member.Birthday.Value.Day, 
                    member.Birthday.Value.Month, 
                    member.Birthday.Value.Year);
            if (member.Status.HasValue)
                this.Status = member.Status.Value == true ? "living" : "Decease";
            this.Birthplace = member.Birthplace;
            this.Living = member.Living;
            this.Occupation = member.Occupation;
            var db = new OOPCSEntities();
            if (member.Father_id.HasValue)
            {
                var father = db.Members.Find(member.Father_id.Value);
            }
            if (member.Mother_id.HasValue)
            {
                var mother = db.Members.Find(member.Mother_id.Value);
            }
            if (member.Spouse_id.HasValue)
            {
                var spouse = db.Members.Find(member.Spouse_id.Value);
            }
        }
        public int id { get; set; }
        public string Fullname { get; set; }
        public string Gender { get; set; }
        public string Birthday { get; set; }
        public string Status { get; set; }
        public string Birthplace { get; set; }
        public string Living { get; set; }
        public string Occupation { get; set; }
        public string Father_id { get; set; }
        public string Mother_id { get; set; }
        public string Spouse_id { get; set; }
    }
}
