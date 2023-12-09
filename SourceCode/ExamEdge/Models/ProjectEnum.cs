using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace ExamEdge.Models
{
    //project default enum

    public class ProjectEnum
    {
        public enum UserType
        {
            SuperAdmin=1,
            OrganizationAdmin =2,
            BranchAdmin =3,
            Teacher =4,
            Student=5
        }
        public enum ModuleCode
        {
            UserStatus,
            UserAttachmentType,
            RoleManagement,
            UserManagement,
            LoginHistory,
            Dashboard
        }

        public enum UserAttachment
        {
            ProfilePicture
        }

        public enum Gender
        {
            Female,
            Male,
            Other
        }

        public enum UserStatus
        {
            Registered,
            Validated,
            NotValidated,
            Banned
        }

        public enum EmailTemplate
        {
            ConfirmEmail,
            PasswordResetByAdmin
        }

        public enum ExamStatus
        {
            Draft,
            Published,
            [Display(Name = "On Going")]
            OnGoing,
            Ended
        }

        public enum StudentExamStatus
        {
            Upcoming,
            Current,
            Past
        }

    }

}