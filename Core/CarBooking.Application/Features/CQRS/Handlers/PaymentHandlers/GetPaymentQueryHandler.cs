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
    public class GetPaymentQueryHandler : IRequestHandler<GetPaymentQueryRequest, IResponse<ResultPaymentDto>>
    {
        private readonly IPaymentRepository _paymentRepository;
        private readonly IMapper _mapper;

        public GetPaymentQueryHandler(IPaymentRepository paymentRepository, IMapper mapper)
        {
            _paymentRepository = paymentRepository;
            _mapper = mapper;
        }

        public async Task<IResponse<ResultPaymentDto>> Handle(GetPaymentQueryRequest request, CancellationToken cancellationToken)
        {
            var payment = await _paymentRepository.GetByIdAsync(request.PaymentId);
            if (payment == null) return new Response<ResultPaymentDto>(false,"Payment is not found",default);
            var paymentDto =_mapper.Map<ResultPaymentDto>(payment);
            return new Response<ResultPaymentDto>(true,"Payment is listed Successfully",paymentDto);
        }
    }
}
