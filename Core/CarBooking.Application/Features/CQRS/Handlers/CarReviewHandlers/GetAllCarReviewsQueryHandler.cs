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
    public class GetAllCarReviewsQueryHandler : IRequestHandler<GetAllCarReviewsQueryRequest, IResponse<List<ResultCarReviewDto>>>
    {
        private readonly ICarReviewRepository _carReviewRepository;
        private readonly IMapper _mapper;

        public GetAllCarReviewsQueryHandler(ICarReviewRepository carReviewRepository, IMapper mapper)
        {
            _carReviewRepository = carReviewRepository;
            _mapper = mapper;
        }

        public async Task<IResponse<List<ResultCarReviewDto>>> Handle(GetAllCarReviewsQueryRequest request, CancellationToken cancellationToken)
        {
            var carReviews = await _carReviewRepository.GetAllAsync();
            if (carReviews == null) return new Response<List<ResultCarReviewDto>>(false,"Car reviews are not found",default);
            var reviewDto = _mapper.Map<List<ResultCarReviewDto>>(carReviews);
            return new Response<List<ResultCarReviewDto>>(true,"Car reviews are listed successfully",reviewDto);
        }
    }
}
