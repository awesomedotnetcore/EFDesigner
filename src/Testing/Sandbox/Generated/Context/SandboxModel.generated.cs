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
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace Sandbox
{
   /// <summary>
   /// xxx
   /// </summary>
   public partial class SandboxModel : System.Data.Entity.DbContext
   {
      #region DbSets
      public virtual System.Data.Entity.DbSet<Sandbox.Entity1> Entity1 { get; set; }
      public virtual System.Data.Entity.DbSet<Sandbox.Entity11> Entity11 { get; set; }
      public virtual System.Data.Entity.DbSet<Sandbox.Entity12> Entity12 { get; set; }
      public virtual System.Data.Entity.DbSet<Sandbox.Entity3> Entity3 { get; set; }
      #endregion DbSets

      /// <summary>
      /// Default connection string
      /// </summary>
      public static string ConnectionString { get; set; } = @"Data Source=.;Initial Catalog=Test;Integrated Security=True";
      /// <inheritdoc />
      public SandboxModel() : base(ConnectionString)
      {
         Configuration.LazyLoadingEnabled = true;
         Configuration.ProxyCreationEnabled = true;
         System.Data.Entity.Database.SetInitializer<SandboxModel>(new SandboxModelDatabaseInitializer());
         CustomInit();
      }

      /// <inheritdoc />
      public SandboxModel(string connectionString) : base(connectionString)
      {
         Configuration.LazyLoadingEnabled = true;
         Configuration.ProxyCreationEnabled = true;
         System.Data.Entity.Database.SetInitializer<SandboxModel>(new SandboxModelDatabaseInitializer());
         CustomInit();
      }

      /// <inheritdoc />
      public SandboxModel(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model) : base(connectionString, model)
      {
         Configuration.LazyLoadingEnabled = true;
         Configuration.ProxyCreationEnabled = true;
         System.Data.Entity.Database.SetInitializer<SandboxModel>(new SandboxModelDatabaseInitializer());
         CustomInit();
      }

      /// <inheritdoc />
      public SandboxModel(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection) : base(existingConnection, contextOwnsConnection)
      {
         Configuration.LazyLoadingEnabled = true;
         Configuration.ProxyCreationEnabled = true;
         System.Data.Entity.Database.SetInitializer<SandboxModel>(new SandboxModelDatabaseInitializer());
         CustomInit();
      }

      /// <inheritdoc />
      public SandboxModel(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection) : base(existingConnection, model, contextOwnsConnection)
      {
         Configuration.LazyLoadingEnabled = true;
         Configuration.ProxyCreationEnabled = true;
         System.Data.Entity.Database.SetInitializer<SandboxModel>(new SandboxModelDatabaseInitializer());
         CustomInit();
      }

      /// <inheritdoc />
      public SandboxModel(System.Data.Entity.Infrastructure.DbCompiledModel model) : base(model)
      {
         Configuration.LazyLoadingEnabled = true;
         Configuration.ProxyCreationEnabled = true;
         System.Data.Entity.Database.SetInitializer<SandboxModel>(new SandboxModelDatabaseInitializer());
         CustomInit();
      }

      /// <inheritdoc />
      public SandboxModel(System.Data.Entity.Core.Objects.ObjectContext objectContext, bool dbContextOwnsObjectContext) : base(objectContext, dbContextOwnsObjectContext)
      {
         Configuration.LazyLoadingEnabled = true;
         Configuration.ProxyCreationEnabled = true;
         System.Data.Entity.Database.SetInitializer<SandboxModel>(new SandboxModelDatabaseInitializer());
         CustomInit();
      }

      partial void CustomInit();
      partial void OnModelCreatingImpl(System.Data.Entity.DbModelBuilder modelBuilder);
      partial void OnModelCreatedImpl(System.Data.Entity.DbModelBuilder modelBuilder);

      /// <inheritdoc />
      protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
      {
         base.OnModelCreating(modelBuilder);
         OnModelCreatingImpl(modelBuilder);

         modelBuilder.HasDefaultSchema("dbo");




         modelBuilder.Entity<Sandbox.Entity3>()
                     .ToTable("Entity3")
                     .HasKey(t => t.Id);
         modelBuilder.Entity<Sandbox.Entity3>()
                     .Property(t => t.Id)
                     .IsRequired()
                     .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute()))
                     .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
         modelBuilder.Entity<Sandbox.Entity3>()
                     .Property(t => t.Property2)
                     .HasMaxLength(2)
                     .HasColumnType("varchar");
         modelBuilder.Entity<Sandbox.Entity3>()
                     .Property(t => t.Property3)
                     .HasMaxLength(9);

         OnModelCreatedImpl(modelBuilder);
      }
   }
}
