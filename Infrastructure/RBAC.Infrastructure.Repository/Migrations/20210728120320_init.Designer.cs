﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RBAC.Infrastructure.Repository;

namespace RBAC.Infrastructure.Repository.Migrations
{
    [DbContext(typeof(RBACDBContext))]
    [Migration("20210728120320_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RBAC.Entitys.Authority", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AuthorityCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthorityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Create")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreateBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MenuPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sort")
                        .HasColumnType("int");

                    b.Property<Guid>("SuperiorID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SystemCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Update")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdateBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.ToTable("Authorities");
                });

            modelBuilder.Entity("RBAC.Entitys.Group", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Create")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreateBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Update")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdateBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("RBAC.Entitys.Identity", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Create")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreateBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrgID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ParentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PositionCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Update")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdateBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.ToTable("Identities");
                });

            modelBuilder.Entity("RBAC.Entitys.MutuallyExclusive", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AuthorityIDA")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AuthorityIDB")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Create")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreateBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Update")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdateBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.ToTable("MutuallyExclusives");
                });

            modelBuilder.Entity("RBAC.Entitys.Organization", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Create")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreateBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ParentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Update")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdateBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("RBAC.Entitys.RelGroupRole", b =>
                {
                    b.Property<DateTime>("Create")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreateBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GroupID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Update")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdateBy")
                        .HasColumnType("uniqueidentifier");

                    b.ToTable("RelGroupRoles");
                });

            modelBuilder.Entity("RBAC.Entitys.RelIdentityRole", b =>
                {
                    b.Property<DateTime>("Create")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreateBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdentityID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Update")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdateBy")
                        .HasColumnType("uniqueidentifier");

                    b.ToTable("RelIdentityRoles");
                });

            modelBuilder.Entity("RBAC.Entitys.RelOrgRole", b =>
                {
                    b.Property<DateTime>("Create")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreateBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrgID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Update")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdateBy")
                        .HasColumnType("uniqueidentifier");

                    b.ToTable("RelOrgRoles");
                });

            modelBuilder.Entity("RBAC.Entitys.RelRoleAut", b =>
                {
                    b.Property<Guid>("AuthorityID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Create")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreateBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Update")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdateBy")
                        .HasColumnType("uniqueidentifier");

                    b.ToTable("RelRoleAuts");
                });

            modelBuilder.Entity("RBAC.Entitys.RelUserGroup", b =>
                {
                    b.Property<DateTime>("Create")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreateBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GroupID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Update")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdateBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.ToTable("RelUserGroups");
                });

            modelBuilder.Entity("RBAC.Entitys.RelUserIdentity", b =>
                {
                    b.Property<DateTime>("Create")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreateBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdentityID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Update")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdateBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.ToTable("RelUserIdentities");
                });

            modelBuilder.Entity("RBAC.Entitys.RelUserOrg", b =>
                {
                    b.Property<DateTime>("Create")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreateBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrgID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Update")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdateBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.ToTable("RelUserOrgs");
                });

            modelBuilder.Entity("RBAC.Entitys.Role", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Create")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreateBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RoleCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SuperiorID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Update")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdateBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("RBAC.Entitys.User", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Create")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreateBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Update")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdateBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
