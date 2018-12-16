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

namespace Sandbox
{
   public partial class Entity3 : INotifyPropertyChanged
   {
      partial void Init();

      /// <summary>
      /// Default constructor
      /// </summary>
      public Entity3()
      {
         Property1 = Sandbox.Enum1ab.ModelEnumValue1a;

         Init();
      }

      /*************************************************************************
       * Persistent properties
       *************************************************************************/

      /// <summary>
      /// Backing field for Id
      /// </summary>
      protected int _Id;
      /// <summary>
      /// When provided in a partial class, allows value of _Id to be changed before setting.
      /// </summary>
      partial void SetId(int oldValue, ref int newValue);
      /// <summary>
      /// When provided in a partial class, allows value of _Id to be changed before returning.
      /// </summary>
      partial void GetId(ref int result);

      /// <summary>
      /// Identity, Required, Indexed
      /// </summary>
      [Key]
      [Required]
      public int Id
      {
         get
         {
            int value = _Id;
            GetId(ref value);
            return (_Id = value);
         }
         set
         {
            int oldValue = _Id;
            SetId(oldValue, ref value);
            if (oldValue != value)
            {
               _Id = value;
               OnPropertyChanged();
            }
         }
      }

      /// <summary>
      /// Backing field for Property1
      /// </summary>
      protected Sandbox.Enum1ab? _Property1;
      /// <summary>
      /// When provided in a partial class, allows value of _Property1 to be changed before setting.
      /// </summary>
      partial void SetProperty1(Sandbox.Enum1ab? oldValue, ref Sandbox.Enum1ab? newValue);
      /// <summary>
      /// When provided in a partial class, allows value of _Property1 to be changed before returning.
      /// </summary>
      partial void GetProperty1(ref Sandbox.Enum1ab? result);

      /// <summary>
      /// Default value = Sandbox.Enum1ab.ModelEnumValue1a
      /// sss
      /// </summary>
      public Sandbox.Enum1ab? Property1
      {
         get
         {
            Sandbox.Enum1ab? value = _Property1;
            GetProperty1(ref value);
            return (_Property1 = value);
         }
         set
         {
            Sandbox.Enum1ab? oldValue = _Property1;
            SetProperty1(oldValue, ref value);
            if (oldValue != value)
            {
               _Property1 = value;
               OnPropertyChanged();
            }
         }
      }

      /// <summary>
      /// Backing field for Property2
      /// </summary>
      protected string _Property2;
      /// <summary>
      /// When provided in a partial class, allows value of _Property2 to be changed before setting.
      /// </summary>
      partial void SetProperty2(string oldValue, ref string newValue);
      /// <summary>
      /// When provided in a partial class, allows value of _Property2 to be changed before returning.
      /// </summary>
      partial void GetProperty2(ref string result);

      /// <summary>
      /// Max length = 2
      /// </summary>
      [MaxLength(2)]
      [StringLength(2)]
      public string Property2
      {
         get
         {
            string value = _Property2;
            GetProperty2(ref value);
            return (_Property2 = value);
         }
         set
         {
            string oldValue = _Property2;
            SetProperty2(oldValue, ref value);
            if (oldValue != value)
            {
               _Property2 = value;
               OnPropertyChanged();
            }
         }
      }

      /// <summary>
      /// Backing field for Property3
      /// </summary>
      protected string _Property3;
      /// <summary>
      /// When provided in a partial class, allows value of _Property3 to be changed before setting.
      /// </summary>
      partial void SetProperty3(string oldValue, ref string newValue);
      /// <summary>
      /// When provided in a partial class, allows value of _Property3 to be changed before returning.
      /// </summary>
      partial void GetProperty3(ref string result);

      /// <summary>
      /// Max length = 9
      /// xxx
      /// </summary>
      [MaxLength(9)]
      [StringLength(9)]
      public string Property3
      {
         get
         {
            string value = _Property3;
            GetProperty3(ref value);
            return (_Property3 = value);
         }
         set
         {
            string oldValue = _Property3;
            SetProperty3(oldValue, ref value);
            if (oldValue != value)
            {
               _Property3 = value;
               OnPropertyChanged();
            }
         }
      }

      public virtual event PropertyChangedEventHandler PropertyChanged;

      protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
      {
         PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
      }

   }
}

