#pragma warning disable SA1028 // Code must not contain trailing whitespace
/*
 * Meetup Management Service API
 *
 * Meetup Management Service API
 *
 * OpenAPI spec version: 0.1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
#pragma warning restore SA1028 // Code must not contain trailing whitespace

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using DotNetRu.MeetupManagement.WebApi.Contract.Attributes;
using DotNetRu.MeetupManagement.WebApi.Contract.Models;

namespace DotNetRu.MeetupManagement.WebApi.Contract.Controllers
#pragma warning disable SA1028 // Code must not contain trailing whitespace
{ 
    /// <inheritdoc />
    /// <summary>
    /// 
    /// </summary>
#pragma warning restore SA1028 // Code must not contain trailing whitespace
#pragma warning disable SA1649
    public abstract class FriendApiController : ControllerBase
#pragma warning restore SA1649
#pragma warning disable SA1028 // Code must not contain trailing whitespace
    { 
        /// <summary>
        /// Create friend draft
        /// </summary>
        /// <remarks>Create new friend draft.</remarks>
        /// <param name="body"></param>
        /// <response code="201">Draft was successfully created</response>
        /// <response code="400">Invalid request parameters</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="409">Draft is already exists</response>
        [HttpPost]
        [Route("/friends/draft")]
        [ValidateModelState]
        [SwaggerOperation("CreateFriendDraft")]
        [SwaggerResponse(statusCode: 201, type: typeof(FriendDraft), description: "Draft was successfully created")]
        [SwaggerResponse(statusCode: 400, description: "Invalid request parameters")]
        [SwaggerResponse(statusCode: 401, description: "Unauthorized")]
        [SwaggerResponse(statusCode: 409, description: "Draft is already exists")]
        public abstract ActionResult<FriendDraft> CreateFriendDraft([FromBody]CreateFriendDraftParameters body);
        
        /// <summary>
        /// Delete friend draft
        /// </summary>
        
        /// <param name="friendId"></param>
        /// <response code="204">Draft was successfully deleted</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">Speaker not found</response>
        [HttpDelete]
        [Route("/friends/{friendId}/draft")]
        [ValidateModelState]
        [SwaggerOperation("DeleteFriendDraft")]
        [SwaggerResponse(statusCode: 204, description: "Draft was successfully deleted")]
        [SwaggerResponse(statusCode: 401, description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, description: "Speaker not found")]
        public abstract EmptyResult DeleteFriendDraft([FromRoute][Required]string friendId);
        
        /// <summary>
        /// Get friend draft
        /// </summary>
        
        /// <param name="friendId"></param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">Friend not found</response>
        [HttpGet]
        [Route("/friends/{friendId}/draft")]
        [ValidateModelState]
        [SwaggerOperation("GetFriendDraft")]
        [SwaggerResponse(statusCode: 200, type: typeof(FriendDraft), description: "OK")]
        [SwaggerResponse(statusCode: 401, description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, description: "Friend not found")]
        public abstract ActionResult<FriendDraft> GetFriendDraft([FromRoute][Required]string friendId);
        
        /// <summary>
        /// Update friend draft
        /// </summary>
        
        /// <param name="friendId"></param>
        /// <param name="body"></param>
        /// <response code="204">Draft was successfully updated</response>
        /// <response code="400">Invalid request parameters</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">Friend not found</response>
        [HttpPut]
        [Route("/friends/{friendId}/draft")]
        [ValidateModelState]
        [SwaggerOperation("UpdateFriendDraft")]
        [SwaggerResponse(statusCode: 204, description: "Draft was successfully updated")]
        [SwaggerResponse(statusCode: 400, description: "Invalid request parameters")]
        [SwaggerResponse(statusCode: 401, description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, description: "Friend not found")]
        public abstract EmptyResult UpdateFriendDraft([FromRoute][Required]string friendId, [FromBody]UpdateFriendDraftParameters body);
        
        /// <summary>
        /// Get route values for CreateFriendDraft action
        /// </summary>
        protected static object GetCreateFriendDraftRouteValues()
        {
            return new { };
        }

        /// <summary>
        /// Get route values for DeleteFriendDraft action
        /// </summary>
        protected static object GetDeleteFriendDraftRouteValues([FromRoute][Required]string friendId)
        {
            return new { friendId };
        }

        /// <summary>
        /// Get route values for GetFriendDraft action
        /// </summary>
        protected static object GetGetFriendDraftRouteValues([FromRoute][Required]string friendId)
        {
            return new { friendId };
        }

        /// <summary>
        /// Get route values for UpdateFriendDraft action
        /// </summary>
        protected static object GetUpdateFriendDraftRouteValues([FromRoute][Required]string friendId)
        {
            return new { friendId };
        }
    }
#pragma warning restore SA1028 // Code must not contain trailing whitespace
}
