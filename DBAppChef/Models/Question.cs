using DBAppChef.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAppChef
{
    public class Question
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuestionID { get; set; }
        public string QuestionText{ get; set; }
        public int QuestionType { get; set; }
        public int UserID { get; set; }
        
        [ForeignKey("UserID")]
        public virtual User User { get; set; }

        public virtual ICollection<Answer2> Answers { get; set; }
        public virtual ICollection<QuestionTag> QuestionTags { get; set; }

    }
}
