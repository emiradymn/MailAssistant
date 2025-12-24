using MailAssistant.Application.Features.EMailTemplateCategory.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MailAssistant.API.Controllers;

[ApiController]
[Route("api/email-template-categories")]
public class EmailTemplateCategoriesController : ControllerBase
{
    private readonly IMediator _mediator;

    public EmailTemplateCategoriesController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _mediator.Send(new GetEmailTemplateCategoriesQuery());
        return Ok(result);
    }

}
