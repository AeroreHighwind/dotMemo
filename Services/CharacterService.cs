using dotMemo.Interfaces;
using dotMemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotMemo.Services
{
    public class CharacterService : ICharacterService
    {
        public Task<IActionResult> Delete(int characterId)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> FindAll(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> FindOne(int characterId)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> Create(CharacterModel payload)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> Update(int characterId, CharacterModel payload)
        {
            throw new NotImplementedException();
        }
    }
}
