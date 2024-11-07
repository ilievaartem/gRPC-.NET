using Grpc.Core;
using GrpcServer.Data;
using Microsoft.EntityFrameworkCore;

namespace GrpcServer.Services;

public class CommentService : Comment.CommentBase
{
    private readonly ILogger<CommentService> _logger;
    private readonly AppDbContext _context;

    public CommentService(ILogger<CommentService> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public override async Task<CommentModel> GetCommentInfo(CommentLookupModel request, ServerCallContext context)
    {
        var comment = await _context.Comments.FindAsync(request.Id);

        if (comment == null)
        {
            _logger.LogWarning($"No comment found for Id {request.Id}");
            throw new RpcException(new Status(StatusCode.NotFound, "Comment not found"));
        }

        return comment;
    }

    public override async Task GetNewComments(NewCommentRequest request,
        IServerStreamWriter<CommentModel> responseStream, ServerCallContext context)
    {
        var comments = await _context.Comments.ToListAsync();

        foreach (var comment in comments)
        {
            await responseStream.WriteAsync(comment);
        }
    }
}