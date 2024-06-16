using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC.Models
{
     [Table("Student")]
     public class Student  {
       [Key]
       public string StudentID{ get; set; } 
       public string FullName { get; set; }
        

     }     

}