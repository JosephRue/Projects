﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ContosoUniversity.Migrations
{
    public partial class StudentViewModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //    migrationBuilder.DropForeignKey(
            //        name: "FK_CourseAssignment_Instructor_InstructorID",
            //        table: "CourseAssignment");

            //    migrationBuilder.DropForeignKey(
            //        name: "FK_Department_Instructor_InstructorID",
            //        table: "Department");

            //    migrationBuilder.DropForeignKey(
            //        name: "FK_Enrollment_Student_StudentId",
            //        table: "Enrollment");

            //    migrationBuilder.DropForeignKey(
            //        name: "FK_OfficeAssignment_Instructor_InstructorID",
            //        table: "OfficeAssignment");

            //    migrationBuilder.DropTable(
            //        name: "Instructor");

            //    migrationBuilder.DropTable(
            //        name: "Student");

            //    migrationBuilder.CreateTable(
            //        name: "Person",
            //        columns: table => new
            //        {
            //            ID = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //            Discriminator = table.Column<string>(nullable: false),
            //            FirstName = table.Column<string>(maxLength: 50, nullable: false),
            //            LastName = table.Column<string>(maxLength: 50, nullable: false),
            //            HireDate = table.Column<DateTime>(nullable: true),
            //            EnrollmentDate = table.Column<DateTime>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Person", x => x.ID);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "StudentViewModels",
            //        columns: table => new
            //        {
            //            Id = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //            StudentID = table.Column<int>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_StudentViewModels", x => x.Id);
            //            table.ForeignKey(
            //                name: "FK_StudentViewModels_Person_StudentID",
            //                column: x => x.StudentID,
            //                principalTable: "Person",
            //                principalColumn: "ID",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.AddColumn<int>(
            //        name: "StudentViewModelId",
            //        table: "Enrollment",
            //        nullable: true);

            //    migrationBuilder.CreateIndex(
            //        name: "IX_Enrollment_StudentViewModelId",
            //        table: "Enrollment",
            //        column: "StudentViewModelId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_StudentViewModels_StudentID",
            //        table: "StudentViewModels",
            //        column: "StudentID");

            //    migrationBuilder.AddForeignKey(
            //        name: "FK_CourseAssignment_Person_InstructorID",
            //        table: "CourseAssignment",
            //        column: "InstructorID",
            //        principalTable: "Person",
            //        principalColumn: "ID",
            //        onDelete: ReferentialAction.Cascade);

            //    migrationBuilder.AddForeignKey(
            //        name: "FK_Department_Person_InstructorID",
            //        table: "Department",
            //        column: "InstructorID",
            //        principalTable: "Person",
            //        principalColumn: "ID",
            //        onDelete: ReferentialAction.Restrict);

            //    migrationBuilder.AddForeignKey(
            //        name: "FK_Enrollment_Person_StudentId",
            //        table: "Enrollment",
            //        column: "StudentId",
            //        principalTable: "Person",
            //        principalColumn: "ID",
            //        onDelete: ReferentialAction.Cascade);

            //    migrationBuilder.AddForeignKey(
            //        name: "FK_Enrollment_StudentViewModels_StudentViewModelId",
            //        table: "Enrollment",
            //        column: "StudentViewModelId",
            //        principalTable: "StudentViewModels",
            //        principalColumn: "Id",
            //        onDelete: ReferentialAction.Restrict);

            //    migrationBuilder.AddForeignKey(
            //        name: "FK_OfficeAssignment_Person_InstructorID",
            //        table: "OfficeAssignment",
            //        column: "InstructorID",
            //        principalTable: "Person",
            //        principalColumn: "ID",
            //        onDelete: ReferentialAction.Cascade);
        }

    protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_CourseAssignment_Person_InstructorID",
            //    table: "CourseAssignment");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Department_Person_InstructorID",
            //    table: "Department");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Enrollment_Person_StudentId",
            //    table: "Enrollment");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Enrollment_StudentViewModels_StudentViewModelId",
            //    table: "Enrollment");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_OfficeAssignment_Person_InstructorID",
            //    table: "OfficeAssignment");

            //migrationBuilder.DropIndex(
            //    name: "IX_Enrollment_StudentViewModelId",
            //    table: "Enrollment");

            //migrationBuilder.DropColumn(
            //    name: "StudentViewModelId",
            //    table: "Enrollment");

            //migrationBuilder.DropTable(
            //    name: "StudentViewModels");

            //migrationBuilder.DropTable(
            //    name: "Person");

            //migrationBuilder.CreateTable(
            //    name: "Instructor",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        FirstName = table.Column<string>(maxLength: 50, nullable: false),
            //        HireDate = table.Column<DateTime>(nullable: false),
            //        LastName = table.Column<string>(maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Instructor", x => x.ID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Student",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        EnrollmentDate = table.Column<DateTime>(nullable: false),
            //        FirstName = table.Column<string>(maxLength: 50, nullable: false),
            //        LastName = table.Column<string>(maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Student", x => x.ID);
            //    });

            //migrationBuilder.AddForeignKey(
            //    name: "FK_CourseAssignment_Instructor_InstructorID",
            //    table: "CourseAssignment",
            //    column: "InstructorID",
            //    principalTable: "Instructor",
            //    principalColumn: "ID",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Department_Instructor_InstructorID",
            //    table: "Department",
            //    column: "InstructorID",
            //    principalTable: "Instructor",
            //    principalColumn: "ID",
            //    onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Enrollment_Student_StudentId",
            //    table: "Enrollment",
            //    column: "StudentId",
            //    principalTable: "Student",
            //    principalColumn: "ID",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_OfficeAssignment_Instructor_InstructorID",
            //    table: "OfficeAssignment",
            //    column: "InstructorID",
            //    principalTable: "Instructor",
            //    principalColumn: "ID",
            //    onDelete: ReferentialAction.Cascade);
        }
    }
}
