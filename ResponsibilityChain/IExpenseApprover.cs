using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsibilityChain
{
	public interface IExpenseApprover
	{
		ApprovalResponce ApproveExpence(IExpenceReport expenceReport);
	}

	public enum ApprovalResponce
	{
		Deniend,
		Approved,
		BeyondApprovalLimit
	}
}
