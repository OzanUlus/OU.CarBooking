using AutoMapper;
using CarBooking.Application.Dtos.CarReviewDtos;
using CarBooking.Application.Features.CQRS.Queries.CarReviewQueries;
using CarBooking.Application.Interfaces;
using CarBooking.Application.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Handlers.CarReviewHandlers
{
    public class GetCarReviewQueryHandler : IRequestHandler<GetCarReviewQueryRequest, IResponse<ResultCarReviewDto>>
    {
        private readonly ICarReviewRepository _carReviewRepository;
        private readonly IMapper _mapper;

        public GetCarReviewQueryHandler(ICarReviewRepository carReviewRepository, IMapper mapper)
        {
            _carReviewRepository = carReviewRepository;
            _mapper = mapper;
        }

        public async Task<IResponse<ResultCarReviewDto>> Handle(GetCarReviewQueryRequest request, CancellationToken cancellationToken)
        {
            var carReview = await _carReviewRepository.GetByIdAsync(request.CarReviewIc);
            if (carReview == null) return new Response<ResultCarReviewDto>(false,"Car review not found",default);
            var reviewDto = _mapper.Map<ResultCarReviewDto>(carReview);
            return new Response<ResultCarReviewDto>(true, "Car review is listed successfully", reviewDto); 
        }
    }
}
