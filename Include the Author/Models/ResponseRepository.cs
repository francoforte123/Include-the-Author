namespace Include_the_Author.Models
{
    public class ResponseRepository : IResponseRepository
    {
        public readonly List<Response> responses;

        public ResponseRepository()
        {
            responses = new List<Response>();
        }
        public IEnumerable<Response> GetAll()
        {
            return this.responses;
        }

        public void Add(Response response)
        {
            if (this.responses.Any(r => r.Id == response.Id))
            {
                throw new InvalidOperationException("this request already exists");
            }

            this.responses.Add(response);
        }

        public Response GetById(int id)
        {
            return this.responses.Single(r => r.Id == id);
        }

        public void DeleteById(int id)
        {
            this.responses.RemoveAll(r => r.Id == id);
        }

        public void Modify(Response response)
        {
            var existingRequest = this.GetById(response.Id);
            existingRequest.Author = response.Author;
            existingRequest.Description = response.Description;
            existingRequest.IsAccepted = response.IsAccepted;
        }
    }
}
