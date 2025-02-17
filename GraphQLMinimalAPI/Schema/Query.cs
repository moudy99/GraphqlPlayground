namespace GraphQLMinimalAPI.Schema
{
    public class Query
    {

        //here i defind and methods [Query] that will be exposed to the client -- this methods called fields in Graphql and the name of this mehtod 
        // will be the name of the filed that i can use it 

        [GraphQLDeprecated("This field is deprecated")]
        public string instuctions() => "wwwwwwwwwwwwwwwww";

        public Player GetPlayer() => new Player { club = "Real Madrid", Name = "Veni" };

      
    }

    public class Player()
    {
        public string Name { get; set; }

        public string club {  get; set; }
    }
}
