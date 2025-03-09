using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/email")]
public class EmailController : ControllerBase
{
    private readonly RabbitMQPublisher _publisher;

    public EmailController(RabbitMQPublisher publisher)
    {
        _publisher = publisher;
    }

    [HttpPost("send")]
    public IActionResult SendEmail([FromBody] EmailMessage email)
    {
        _publisher.Publish(email);
        return Ok(new { message = "Email queued successfully" });
    }
}
