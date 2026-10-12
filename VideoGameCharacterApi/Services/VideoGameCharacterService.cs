using Microsoft.AspNetCore.Http.HttpResults;
using VideoGameCharacterApi.Models;

namespace VideoGameCharacterApi.Services
{
    public class VideoGameCharacterService : IVideoGameCharacterService
    {
        public static List<Character> characters = new List<Character>
        {
            new Character {Id = 1, Name = "Mario", Game = "Super Mario Bros.", Role = "Protagonist"},
            new Character {Id = 2, Name = "Marcus", Game = "Gears of War", Role = "Protagonist"},
            new Character {Id = 3, Name = "Survivor", Game = "Project Zomboid", Role = "Protagonist"},
        };

        public Task<Character> AddCharacterAsync(Character character)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCharacterAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Character>> GetAllCharactersAsync() => await Task.FromResult(characters);

        public async Task<Character?> GetCharacterByIdAsync(int id)
        {
            var result = characters.FirstOrDefault(c => c.Id == id);

            return await Task.FromResult(result);
        }

        public Task<bool> UpdateCharacterAsync(int id, Character character)
        {
            throw new NotImplementedException();
        }
    }
}
