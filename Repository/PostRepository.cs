using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Color_final.Models;
using Color_final.viewModel;


namespace Color_final.Repository
{
    public class PostRepository : IPostRepository
    {
        TestDBContext db;
        private readonly object _colorService;

        //public IPostRepository _colorService;
        public PostRepository(IPostRepository colorService)
        {
            _colorService = colorService;
        }

        public PostRepository(TestDBContext _db)
        {
            db = _db;
        }
        public List<Color> GetAllColor(string color)
        {
            if (db != null)
            {
                return _colorService.GetAllColor(color).ToList();
            }

            return null;
        }
        public async Task<PostViewModel> GetColorById(int id)
        {

           return (await _colorService.GetColorById(id));
        }

        public async Task<int> DeleteColor(int id)
        {
            if (db != null)
            {
                return await _colorService.DeleteColor(id);
            }
           
        }

        public async Task UpdateColor(Color color) 
        {
            if (db != null)
            {
                 return await _colorService.UpdateColor(color);
            }

        }

        Task<List<Color>> IPostRepository.GetAllColor(string color)
        {
            throw new NotImplementedException();
        }
    }
}
