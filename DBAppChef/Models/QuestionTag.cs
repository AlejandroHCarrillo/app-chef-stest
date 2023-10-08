using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAppChef.Entities
{
    public class QuestionTag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuestionTagId { get; set; }
        public string TagDescription { get; set;}

        public virtual ICollection<Question> questions { get; set; }

    }
}
