using MailAssistant.Application.Features.EMailTemplate.Queries;
using MailAssistant.Application.Features.EMailTemplateCategory.Queries;
using MailAssistant.Application.Features.SendMailForm.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MailAssistant.API.Controllers;

[ApiController]
[Route("api/email-templates")]
public class EmailTemplatesController : ControllerBase
{
    private readonly IMediator _mediator;

    public EmailTemplatesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] Guid? categoryId)
    {
        var result = await _mediator.Send(
            new GetEmailTemplatesQuery(categoryId)
        );

        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _mediator.Send(
            new GetEmailTemplateByIdQuery(id));

        return Ok(result);
    }
}
