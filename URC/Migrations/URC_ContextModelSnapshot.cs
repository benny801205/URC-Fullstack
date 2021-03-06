﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using URC.Data;

namespace URC.Migrations
{
    [DbContext(typeof(URC_Context))]
    partial class URC_ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("URC.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("ApplicationStudentApplicationId")
                        .HasColumnType("int");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("CourseId");

                    b.HasIndex("ApplicationStudentApplicationId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("URC.Models.Interest", b =>
                {
                    b.Property<int>("InterestId")
                        .HasColumnType("int");

                    b.Property<int?>("ApplicationStudentApplicationId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("InterestId");

                    b.HasIndex("ApplicationStudentApplicationId");

                    b.ToTable("Interests");
                });

            modelBuilder.Entity("URC.Models.Opportunity", b =>
                {
                    b.Property<int>("OpportunityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(5000);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFilled")
                        .HasColumnType("bit");

                    b.Property<string>("Mentor")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<double>("Pay")
                        .HasColumnType("float");

                    b.Property<DateTime>("PostedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Professor")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("ProfessorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Responsibilities")
                        .HasColumnType("nvarchar(3000)")
                        .HasMaxLength(3000);

                    b.Property<string>("RoleDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(5000);

                    b.HasKey("OpportunityId");

                    b.ToTable("Opportunities");
                });

            modelBuilder.Entity("URC.Models.OpportunityPreferredSkill", b =>
                {
                    b.Property<int>("OpportunityId")
                        .HasColumnType("int");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.HasKey("OpportunityId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("Opportunities_PreferredSkills");
                });

            modelBuilder.Entity("URC.Models.OpportunityRequiredSkill", b =>
                {
                    b.Property<int>("OpportunityId")
                        .HasColumnType("int");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.HasKey("OpportunityId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("Opportunities_RequiredSkills");
                });

            modelBuilder.Entity("URC.Models.OpportunitySearchTag", b =>
                {
                    b.Property<int>("OpportunityId")
                        .HasColumnType("int");

                    b.Property<int>("SearchTagId")
                        .HasColumnType("int");

                    b.HasKey("OpportunityId", "SearchTagId");

                    b.HasIndex("SearchTagId");

                    b.ToTable("Opportunities_SearchTags");
                });

            modelBuilder.Entity("URC.Models.SearchTag", b =>
                {
                    b.Property<int>("SearchTagId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("SearchTagId");

                    b.ToTable("SearchTags");
                });

            modelBuilder.Entity("URC.Models.Skill", b =>
                {
                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.Property<int?>("ApplicationStudentApplicationId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("SkillId");

                    b.HasIndex("ApplicationStudentApplicationId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("URC.Models.StudentApplication", b =>
                {
                    b.Property<int>("StudentApplicationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ApplicationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Availability")
                        .HasColumnType("int");

                    b.Property<string>("DegreePlan")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<DateTime>("ExpectedGraduation")
                        .HasColumnType("datetime2");

                    b.Property<double>("GPA")
                        .HasColumnType("float");

                    b.Property<bool>("IsLookingForPosition")
                        .HasColumnType("bit");

                    b.Property<string>("PersonalStatement")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("ResumeFilename")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("UId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentApplicationId");

                    b.ToTable("StudentApplications");
                });

            modelBuilder.Entity("URC.Models.Course", b =>
                {
                    b.HasOne("URC.Models.StudentApplication", "Application")
                        .WithMany("CompletedCourses")
                        .HasForeignKey("ApplicationStudentApplicationId")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("URC.Models.Interest", b =>
                {
                    b.HasOne("URC.Models.StudentApplication", "Application")
                        .WithMany("Interests")
                        .HasForeignKey("ApplicationStudentApplicationId")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("URC.Models.OpportunityPreferredSkill", b =>
                {
                    b.HasOne("URC.Models.Opportunity", "Opportunity")
                        .WithMany("PreferredSkills")
                        .HasForeignKey("OpportunityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("URC.Models.Skill", "Skill")
                        .WithMany("OpportunityPreferredSkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("URC.Models.OpportunityRequiredSkill", b =>
                {
                    b.HasOne("URC.Models.Opportunity", "Opportunity")
                        .WithMany("RequiredSkills")
                        .HasForeignKey("OpportunityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("URC.Models.Skill", "Skill")
                        .WithMany("OpportunityRequiredSkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("URC.Models.OpportunitySearchTag", b =>
                {
                    b.HasOne("URC.Models.Opportunity", "Opportunity")
                        .WithMany("Tags")
                        .HasForeignKey("OpportunityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("URC.Models.SearchTag", "SearchTag")
                        .WithMany("OpportunitySearchTags")
                        .HasForeignKey("SearchTagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("URC.Models.Skill", b =>
                {
                    b.HasOne("URC.Models.StudentApplication", "Application")
                        .WithMany("Skills")
                        .HasForeignKey("ApplicationStudentApplicationId")
                        .OnDelete(DeleteBehavior.SetNull);
                });
#pragma warning restore 612, 618
        }
    }
}
