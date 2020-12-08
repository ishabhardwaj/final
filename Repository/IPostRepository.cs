using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Color_final.Models;
using Color_final.viewModel;



namespace Color_final.Repository
{
    interface IPostRepository
    {
        Task<List<Color>> GetAllColor( string color);

        Task<PostViewModel> GetColorById(int id);

        Task<int> DeleteColor(int id);

        Task UpdateColor(Color color);
    }
}
