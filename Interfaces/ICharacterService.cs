
using dotMemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotMemo.Interfaces
{
    public interface ICharacterService
    {
        public Task<IActionResult> Update(int characterId, CharacterModel payload);

        public Task<IActionResult> Create(CharacterModel payload);

        public Task<IActionResult> Delete(int characterId);

        public Task<IActionResult> FindOne(int characterId);

        public Task<IActionResult> FindAll(int userId);
    }
}
