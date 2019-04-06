//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
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
using System.Data.Entity.Spatial;

namespace Testing
{
   public partial class UParentRequired
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected UParentRequired()
      {
         UChildCollection = new System.Collections.ObjectModel.ObservableCollection<Testing.UChild>();

         Init();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="uchildrequired"></param>
      public UParentRequired(Testing.UChild uchildrequired)
      {
         if (uchildrequired == null) throw new ArgumentNullException(nameof(uchildrequired));
         UChildRequired = uchildrequired;

         UChildCollection = new System.Collections.ObjectModel.ObservableCollection<Testing.UChild>();
         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="uchildrequired"></param>
      public static UParentRequired Create(Testing.UChild uchildrequired)
      {
         return new UParentRequired(uchildrequired);
      }

      /*************************************************************************
       * Persistent properties
       *************************************************************************/

      /// <summary>
      /// Identity, Required, Indexed
      /// </summary>
      [Key]
      [Required]
      public int Id { get; set; }

      /*************************************************************************
       * Persistent navigation properties
       *************************************************************************/

      /// <summary>
      /// Required
      /// </summary>
      public virtual Testing.UChild UChildRequired { get; set; }

      public virtual ICollection<Testing.UChild> UChildCollection { get; set; }

      public virtual Testing.UChild UChildOptional { get; set; }

   }
}

