using AutoMapper;
using CarBooking.Application.Dtos.PaymentDtos;
using CarBooking.Application.Features.CQRS.Queries.PaymentQueries;
using CarBooking.Application.Interfaces;
using CarBooking.Application.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Handlers.PaymentHandlers
{
    public class GetAllPaymentsQueryHandler : IRequestHandler<GetAllPaymentsQueryRequest, IResponse<List<ResultPaymentDto>>>
    {
        private readonly IPaymentRepository _paymentRepository;
        private readonly IMapper _mapper;

        public GetAllPaymentsQueryHandler(IPaymentRepository paymentRepository, IMapper mapper)
        {
            _paymentRepository = paymentRepository;
            _mapper = mapper;
        }

        public async Task<IResponse<List<ResultPaymentDto>>> Handle(GetAllPaymentsQueryRequest request, CancellationToken cancellationToken)
        {
            var payments = await _paymentRepository.GetAllAsync();
            if (payments == null) return new Response<List<ResultPaymentDto>>(false,"Payments are not found",default);
            var paymentsDto = _mapper.Map<List<ResultPaymentDto>>(payments);
            return new Response<List<ResultPaymentDto>>(true,"Payments are listed successfully",paymentsDto);
        }
    }
}
