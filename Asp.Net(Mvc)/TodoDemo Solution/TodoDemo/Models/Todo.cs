using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TodoDemo.Models
{
    public class Todo
    {
        // primary key => unique , notnull , auto incremeant
        public int Id { get; set; }

        // server Side Validation
        [Required(ErrorMessage ="Todo Name is Required ")]
        public string Name { get; set; }

        public string? Description { get; set; }
        
        public bool isFinished { get; set; }

        public DateTime CreatedDate { get; set;}
    }
}
