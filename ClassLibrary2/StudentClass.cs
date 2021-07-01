using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary
{
    //one to one relationship
    [Table("StudentDb")]                    //The Table attribute can be applied to a class to configure the corresponding table name in the database. It overrides the default convention in EF 6 and EF Core
    public class StudentClass
    {

        
        public int id { get; set; }               //The Key attribute can be applied to a property in an entity class to make it a key property and the corresponding column to a PrimaryKey column in the database. 
        public string name { get; set; }
        public int salary { get; set; }

        [NotMapped]
        public string qual { get; set; }      //The NotMapped attribute can be applied to properties of an entity class for which we do not want to create corresponding columns in the database.
     
        [Required]
        public virtual StudentAdd address { get; set; }
        //virtual is used when a method's basic functionality is the same but sometimes more functionality is needed in the derived class
        //is used to override base class

    }
    
    public class StudentAdd
    {
        [Key]
        public int sid { get; set; }
        public string city { get; set; }
        public int zipcode { get; set; }

        public virtual StudentClass StudentClass { get; set; }
    }
    
}
    
