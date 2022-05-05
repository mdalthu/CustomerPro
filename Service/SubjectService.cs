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
    public class SubjectService
    {
		private AppDbContext _context;

		public SubjectService(AppDbContext context)
		{
			_context = context;
		}


		public void AddSubject(SubjectVM customer)
		{
			var _customer = new Subject()
			{
				Sub_Name = customer.Sub_Name,
				Cat_Id=customer.Cat_Id

			};
			_context.Subjects.Add(_customer);
			_context.SaveChanges();
		}

		public  List<Subject> GetAllSubjects() => _context.Subjects.ToList();


		public List<SubjectVM> GetSubjectById(int Id)

		{
		var _productwith = _context.Subjects.Where(n => n.Cat_Id == Id).Select(product => new SubjectVM()
			{
			Cat_Id = product.Cat_Id,
			Sub_Name = product.Sub_Name
			
}).ToList();

return _productwith;
}
}
}
