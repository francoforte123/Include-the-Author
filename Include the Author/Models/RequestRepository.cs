namespace Include_the_Author.Models
{
    public class RequestRepository : IRequestRepository
    {
        public readonly List<Request> requests;

        public RequestRepository()
        {
            this.requests = new List<Request>
            {
                new Request
                {
                    Id = 1,
                    Author= "Steven Spielberg",
                    Title= "Movies of Steven Spielberg",
                    Description= "Write some movies turn around of Steven Spielberg",
                    Responses= new List<Response>()
                    {
                        new Response
                        {
                            Id= 1,
                            Author= "Steven Spielberg",
                            Description= "Lo Squalo, Jurassic Park, Prova a prendermi, Schinder's list, Salvate il soldato Ryan, Ritorno al futuro, Indiana Jones",
                            IsAccepted= "true",
                            Request= new Request()
                        },
                        new Response
                        {
                            Id= 2,
                            Author= "Steven Spielberg",
                            Description= "I cavalieri dello zodiaco, Non così vicino, Mia, Il colibrì, Il grande giorno, Megan, L'esercista del papa",
                            IsAccepted= "false",
                            Request= new Request()
                        },
                        new Response
                        {
                            Id= 3,
                            Author= "Steven Spielberg",
                            Description= "Cocainorso, Grazie ragazzi, Fast & Furious 10, Black Adam, La stranezza, John Wick 4, Dune, House of Gucci",
                            IsAccepted= "false",
                            Request= new Request()
                        },
                    }
                },

                new Request
                {
                    Id = 2,
                    Author= "Test",
                    Title= "Test",
                    Description= "Test",
                    Responses= new List<Response>(){}
                }
            };
        }
        public IEnumerable<Request> GetAll()
        {
            return this.requests;
        }

        public void Add(Request request)
        {
            if (this.requests.Any(r => r.Id == request.Id))
            {
                throw new InvalidOperationException("this request already exists");
            }

            this.requests.Add(request);
        }

        public Request GetById(int id)
        {
            return this.requests.Single(r => r.Id == id);
        }

        public void DeleteById(int id)
        {
            this.requests.RemoveAll(r => r.Id == id);
        }

        public void Modify(Request request)
        {
            var existingRequest = this.GetById(request.Id);
            existingRequest.Author = request.Author;
            existingRequest.Title = request.Title;
            existingRequest.Description = request.Description;
        }
    }
}
