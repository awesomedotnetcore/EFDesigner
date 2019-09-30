//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//     Produced by Entity Framework Visual Editor v1.3.0.6
//     Source:                    https://github.com/msawczyn/EFDesigner
//     Visual Studio Marketplace: https://marketplace.visualstudio.com/items?itemName=michaelsawczyn.EFDesigner
//     Documentation:             https://msawczyn.github.io/EFDesigner/
//     License (MIT):             https://github.com/msawczyn/EFDesigner/blob/master/LICENSE
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Testing_EFCoreV3
{
   public partial class Entity1
   {
      partial void Init();

      /// <summary>
      /// Default constructor
      /// </summary>
      public Entity1()
      {
         Entity2 = new System.Collections.Generic.HashSet<global::Testing_EFCoreV3.Entity2>();

         Init();
      }

      /*************************************************************************
       * Persistent properties
       *************************************************************************/

      /// <summary>
      /// Identity, Required, Indexed
      /// </summary>
      [Key]
      [Required]
      public int Id { get; private set; }

      /// <summary>
      /// Backing field for Property1
      /// </summary>
      protected string _Property1;
      /// <summary>
      /// When provided in a partial class, allows value of Property1 to be changed before setting.
      /// </summary>
      partial void SetProperty1(string oldValue, ref string newValue);
      /// <summary>
      /// When provided in a partial class, allows value of Property1 to be changed before returning.
      /// </summary>
      partial void GetProperty1(ref string result);

      /// <summary>
      /// Indexed
      /// </summary>
      public string Property1
      {
         get
         {
            string value = _Property1;
            GetProperty1(ref value);
            return (_Property1 = value);
         }
         set
         {
            string oldValue = _Property1;
            SetProperty1(oldValue, ref value);
            if (oldValue != value)
            {
               _Property1 = value;
            }
         }
      }

      /*************************************************************************
       * Persistent navigation properties
       *************************************************************************/

      public virtual ICollection<global::Testing_EFCoreV3.Entity2> Entity2 { get; private set; }

   }
}
