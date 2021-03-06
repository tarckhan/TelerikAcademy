﻿namespace StudentsAndWorkers.Models
{
	using Interfaces;

	public class Worker: Human, IHuman, IWorker
	{
		public Worker(string firstName, string lastName, float weekSalary, float workHoursPerDay)
			: base(firstName, lastName)
		{
			this.WeekSalary = weekSalary;
			this.WorkHoursPerDay = workHoursPerDay;
		}

		public float WeekSalary { get; }
		public float WorkHoursPerDay { get; }

		public float MoneyPerHour()
		{
			return this.WeekSalary / 5 / this.WorkHoursPerDay;
		}
	}
}