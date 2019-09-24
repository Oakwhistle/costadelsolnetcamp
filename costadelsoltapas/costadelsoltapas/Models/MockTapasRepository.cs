using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Linq;
using System.Threading.Tasks;

namespace costadelsoltapas.Models
{
    public class MockTapasRepository : ITapasRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Tapas> AllTapas =>
            new List<Tapas>
{
                new Tapas {TapasID = 1, Name="Tortilla de Patatas", Price=5.95M, ShortDescription="Lorem Ipsum", LongDescription=" The absolute classic. Found everywhere in Spain, it is not hard to see why this is an staple tapa in a culture where the quality of food is of upmost importance.", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://lacocinadefrabisa.lavozdegalicia.es/wp-content/uploads/2019/05/tortilla-española.jpg", InStock=true, IsTapasOfTheWeek=false, ImageThumbnailUrl="https://lacocinadefrabisa.lavozdegalicia.es/wp-content/uploads/2019/05/tortilla-española.jpg"},
                new Tapas {TapasID = 2, Name="Croquetas del Dia", Price=8.95M, ShortDescription="Lorem Ipsum", LongDescription="Bite sized croquettes filled with the best Jamon and gently fried in olive oil.", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="http://www.importdelicia.com/contenido/noticias/600_img_36.jpg", InStock=true, IsTapasOfTheWeek=false, ImageThumbnailUrl="http://www.importdelicia.com/contenido/noticias/600_img_36.jpg"},
                new Tapas {TapasID = 3, Name="Polbo a Feira", Price=12.95M, ShortDescription="Lorem Ipsum", LongDescription="Despite being originally from the northern regions of Spain, this traditional Galician octopus dish is a star of the spanish cuisine.", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="http://porsolea.com/wp-content/uploads/2017/04/pulpo-a-la-gallega-2.jpg", InStock=true, IsTapasOfTheWeek=true, ImageThumbnailUrl="http://porsolea.com/wp-content/uploads/2017/04/pulpo-a-la-gallega-2.jpg"},
                new Tapas {TapasID = 4, Name="Tostas Costa del Sol", Price=20.95M, ShortDescription="Lorem Ipsum", LongDescription="Handmade bread, toasted and crowned with the best toppings choosed by the chef according with the current season.", Category = _categoryRepository.AllCategories.ToList()[1],ImageUrl="https://jamonesjuanpedrodomecq.com/wp-content/uploads/2019/05/Tapas-españolas.jpg", InStock=true, IsTapasOfTheWeek=true, ImageThumbnailUrl="https://jamonesjuanpedrodomecq.com/wp-content/uploads/2019/05/Tapas-españolas.jpg"},
                new Tapas {TapasID = 4, Name="Jamon Iberico", Price=20.95M, ShortDescription="Lorem Ipsum", LongDescription="The best Jamon Iberico 100% Bellota carefully sliced and presented by an expert of the craft. The best of the best. The Ballon d'Or of the Tapas. ", Category = _categoryRepository.AllCategories.ToList()[2],ImageUrl="https://www.ibericosguillen.com/tienda/wp-content/uploads/2018/10/Jamon-iberico-bellota-50-Guillen-1-1.jpg", InStock=true, IsTapasOfTheWeek=true, ImageThumbnailUrl="https://www.ibericosguillen.com/tienda/wp-content/uploads/2018/10/Jamon-iberico-bellota-50-Guillen-1-1.jpg"}
};

        public IEnumerable<Tapas> TapasOfTheWeek { get; }

        public Tapas GetTapasById(int TapasId)
        {
            return AllTapas.FirstOrDefault(p => p.TapasID == TapasId);
        }
    }
}
