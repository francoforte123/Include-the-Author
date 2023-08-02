namespace Include_the_Author.Models
{
    public interface IResponseRepository
    {
        void Add(Response request);
        void DeleteById(int id);
        IEnumerable<Response> GetAll();
        Response GetById(int id);
        void Modify(Response request);
    }
}
