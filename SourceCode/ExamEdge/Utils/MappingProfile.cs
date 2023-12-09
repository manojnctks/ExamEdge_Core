using AutoMapper;
using ExamEdge.Models;
using System.IO.Packaging;

namespace ExamEdge.Utils
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<StudentAnswer, StudentAnswerCloned>();
        }
    }

}
