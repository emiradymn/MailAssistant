using MailAssistant.API.Models;
using MailAssistant.Application.Features.SendMail.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MailAssistant.API.Controllers;

[ApiController]
[Route("api/mails")]
public class MailController : ControllerBase
{
    private readonly IMediator _mediator;

    public MailController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("send")]
    public async Task<IActionResult> Send([FromForm] SendMailRequest request)
    {
        byte[]? bytes = null;

        if (request.File != null)
        {
            using var ms = new MemoryStream();
            await request.File.CopyToAsync(ms);
            bytes = ms.ToArray();
        }

        var command = new SendMailCommand
        {
            TemplateId = request.TemplateId,
            From = request.From,
            To = request.To,
            Subject = request.Subject,
            Params = request.Params,
            FileContent = bytes,
            FileName = request.File?.FileName,
            ContentType = request.File?.ContentType
        };

        var id = await _mediator.Send(command);
        return Ok(id);
    }

}
