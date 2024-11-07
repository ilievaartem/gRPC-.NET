using Grpc.Core;
using Grpc.Net.Client;
using GrpcServer;

namespace GrpcClient;

class Program
{
    static async Task Main(string[] args)
    {
        var channel = GrpcChannel.ForAddress("https://localhost:5001");
        var commentClient = new Comment.CommentClient(channel);

        var clientRequested = new CommentLookupModel { Id = 1 };

        var comment = await commentClient.GetCommentInfoAsync(clientRequested);

        Console.WriteLine($"{comment.UserId} {comment.PhotoId}");

        using (var call = commentClient.GetNewComments(new NewCommentRequest()))
        {
            while (await call.ResponseStream.MoveNext())
            {
                var currentComment = call.ResponseStream.Current;
                
                Console.WriteLine($"{currentComment.UserId} {currentComment.CommentText} {currentComment.PhotoId} {currentComment.CreatedAt} {currentComment.UpdatedAt}");
            }
        }
    }
}