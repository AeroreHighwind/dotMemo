using dotMemo.Entities;
using dotMemo.Interfaces;
using dotMemo.Models;
using dotMemo.Services;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace dotMemo.Controllers
{
    [ApiController]
    [Route("characters")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService characterService;
        public CharacterController(ICharacterService _charService) { 
            this.characterService = _charService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] [NotNull] CharacterModel newCharacter)
        {
            return await characterService.Create(newCharacter);
        }

        [HttpGet("find-one")]
        public async Task<IActionResult> FindOne([FromRoute][NotNull] int characterId)
        {
            return await characterService.FindOne(characterId);
        }

        [HttpGet("find-all")]
        public async Task<IActionResult> FindAll([FromRoute][NotNull] int userId)
        {
            return await characterService.FindAll(userId);
        }
        //Add id to route param
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromRoute][NotNull] int characterId, [FromBody][NotNull] CharacterModel updatedCharacter)
        {
            return await characterService.Update(characterId, updatedCharacter);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromBody][NotNull] int characterId)
        {
            return await characterService.Delete(characterId);
        }

    }
}
