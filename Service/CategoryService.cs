using CustomerPro.Data.Context;
using CustomerPro.Data.Model;
using CustomerPro.Data.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerPro.Service
{
    public class CategoryService
    {
		private AppDbContext _context;

		public CategoryService(AppDbContext context)
		{
			_context = context;
		}

		
		public void AddCategory(CategoryVM customer)
		{
			var _customer = new Category()
			{	
				Cat_Name = customer.Cat_Name	
			};
			_context.Categorys.Add(_customer);
			_context.SaveChanges();
		}

		public List<Category> GetAllCateogrys() => _context.Categorys.ToList();

		/*
		public List<ResponseVM> GetResults()

		{
			var _result = _context.Categorys.Select(n => new ResponseVM()
			{
				Cat_Id = n.Cat_Id,
				Cat_Name = n.Cat_Name
				
			}).ToList();
			return _result ;

		}

		/*
			public async Task<List<SubjectVM>> GetSubjects()

            {
				var _results = await (from l in _context.Categorys
									 join t in _context.Subjects on l.Cat_Id equals t.Cat_Id
									 where l.Cat_Id == t.Cat_Id
									 select new SubjectVM
									 {

										 Sub_Name = t.Sub_Name

									 }).ToListAsync();
			}
				
				
		*/
		public  List<ResponseVM> GetResults()
		{
			var Response =  (from l in _context.Categorys


							select new ResponseVM
							{
								Cat_Id = l.Cat_Id,
								Cat_Name = l.Cat_Name,
								Subjects = new List<SubjectVM>(from t in _context.Subjects
															   where l.Cat_Id == t.Cat_Id
															   select new SubjectVM

															   {
																   Sub_Name = t.Sub_Name,
																   Cat_Id = t.Cat_Id
															   }).ToList()

							}).ToList();

			return Response;
			
		}
		

		


		public Category GetCategoryById(int Id) => _context.Categorys.FirstOrDefault(n => n.Cat_Id== Id);

	}

}


