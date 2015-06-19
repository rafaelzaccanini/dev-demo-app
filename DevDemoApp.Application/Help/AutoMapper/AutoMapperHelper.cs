using AutoMapper;
using System.Collections.Generic;

namespace DevDemoApp.Application.AutoMapper
{
    public class AutoMapperHelper
    {
        /// <summary>
        /// Map two entities.
        /// </summary>
        /// <typeparam name="TIn"></typeparam>
        /// <typeparam name="TOut"></typeparam>
        /// <param name="entityIn"></param>
        /// <param name="entityOut"></param>
        /// <returns></returns>
        public static TOut Map<TIn, TOut>(TIn entityIn, TOut entityOut)
            where TIn : class
            where TOut : class, new()
        {
            return CustomMap(entityIn, entityOut, new string[] { });
        }

        /// <summary>
        /// Map two entities with possibility of custom which fields won't be mapped.
        /// </summary>
        /// <typeparam name="TIn"></typeparam>
        /// <typeparam name="TOut"></typeparam>
        /// <param name="entityIn"></param>
        /// <param name="entityOut"></param>
        /// <param name="propertiesToNotMap"></param>
        /// <returns></returns>
        public static TOut CustomMap<TIn, TOut>(TIn entityIn, TOut entityOut, string[] propertiesToNotMap)
            where TIn : class
            where TOut : class, new()
        {
            if (entityOut == null)
                entityOut = new TOut();

            var mapper = Mapper.CreateMap<TIn, TOut>();

            foreach (string prop in propertiesToNotMap)
                mapper.ForMember(prop, x => x.Ignore());

            Mapper.Map(entityIn, entityOut);

            return entityOut;
        }

        /// <summary>
        /// Map two collection of entities.
        /// </summary>
        /// <typeparam name="TIn"></typeparam>
        /// <typeparam name="TOut"></typeparam>
        /// <param name="collectionIn"></param>
        /// <param name="collectionOut"></param>
        /// <returns></returns>
        public static IList<TOut> MapList<TIn, TOut>(IList<TIn> collectionIn, IList<TOut> collectionOut)
            where TIn : class
            where TOut : class, new()
        {
            return CustomMapList(collectionIn, collectionOut, new string[] { });
        }

        /// <summary>
        /// Map two collection of entities with possibility of custom which fields won't be mapped.
        /// </summary>
        /// <typeparam name="TIn"></typeparam>
        /// <typeparam name="TOut"></typeparam>
        /// <param name="collectionIn"></param>
        /// <param name="collectionOut"></param>
        /// <param name="propertiesToNotMap"></param>
        /// <returns></returns>
        public static IList<TOut> CustomMapList<TIn, TOut>(IList<TIn> collectionIn, IList<TOut> collectionOut, string[] propertiesToNotMap)
            where TIn : class
            where TOut : class
        {
            var mapper = Mapper.CreateMap<TIn, TOut>();

            foreach (string propriedade in propertiesToNotMap)
                mapper.ForMember(propriedade, x => x.Ignore());

            Mapper.Map(collectionIn, collectionOut);

            return collectionOut;
        }
    }
}
