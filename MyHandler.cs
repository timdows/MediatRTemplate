using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;

namespace $rootnamespace$
{
	public class $servicename$Handler : IRequestHandler<$servicename$Request, $servicename$Response>
	{

		public $servicename$Handler()
		{
		}

		public async Task<$servicename$Response> Handle($servicename$Request request, CancellationToken cancellationToken)
		{
			var validator = new $servicename$RequestValidator();
            var result = validator.Validate(request);

            if (!result.IsValid)
            {
                throw new MediatRValidationException(result.ToString());
            }

			throw new NotImplementedException();
		}
	}
}
