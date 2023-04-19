namespace APIs_Day2_DAL.Repositories
{
    public interface IDepartmentRepository
    {
        Department? GetDepartmentDetailsWithTicketsById(int id);
    }
}
