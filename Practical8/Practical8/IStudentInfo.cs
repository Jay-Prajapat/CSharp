namespace Practical8
{
    public interface IStudentInfo
    {
        void ViewStudent(IManageStudentList studentList);
        void ViewStudent(IManageStudentList studentList, int id);
    }
}