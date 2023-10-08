using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAppChef.Entities
{
    public class Answer2
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AnswerID { get; set; }
        //public int QuestionID { get; set; }
        //public int UserID{ get; set; }
        public string AnswerText { get; set; }
        public int rate { get; set; }

        //[ForeignKey("UserID")]
        //public virtual User User { get; set; }

        //[ForeignKey("QuestionID")]
        //public virtual Question Question { get; set; }



    }
}
