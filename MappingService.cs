
////////////////////////////////////////////////////////
// Прокси класс Маппинга WEB-Моделей и вызова процедур
// Сгенерирован из файла D:\Projects\Core\PluginPackage\models.xml
// Время генерации 14.07.2021 16:26:05
////////////////////////////////////////////////////////

using System;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using UCP.Common.Plugin;
using AutoMapper;
using AutoMapper.Configuration;
using UCP.Common.Plugin.Attributes;

namespace Natec.Entities
{
	[DocIgnore]
	public static class MappingService
	{
        #region [Private]
        private static Lazy<MapperConfigurationExpression> mapperConfigurationExpressionHolder = new Lazy<MapperConfigurationExpression>(() =>
            GetMapperConfigurationExpression());
        private static Lazy<MapperConfigurationExpression> mapperConfigurationExpressionWNHolder = new Lazy<MapperConfigurationExpression>(() =>
            GetMapperConfigurationWNExpression());
        private static Lazy<MapperConfigurationExpression> mapperConfigurationExpressionDefaultHolder = new Lazy<MapperConfigurationExpression>(() =>
            GetMapperConfigurationDefaultExpression());
        private static Lazy<MapperConfiguration> mapperConfigurationHolder = new Lazy<MapperConfiguration>(() =>
            GetMapperConfiguration(0));
        private static Lazy<MapperConfiguration> mapperConfigurationWNHolder = new Lazy<MapperConfiguration>(() =>
            GetMapperConfiguration(1));
        private static Lazy<MapperConfiguration> mapperConfigurationDefaultHolder = new Lazy<MapperConfiguration>(() =>
            GetMapperConfiguration(2));

        private static Lazy<IMapper> mapperHolder = new Lazy<IMapper>(() =>
            mapperConfigurationHolder.Value.CreateMapper());
        private static Lazy<IMapper> mapperWNHolder = new Lazy<IMapper>(() =>
            mapperConfigurationWNHolder.Value.CreateMapper());
        private static Lazy<IMapper> mapperDefaultHolder = new Lazy<IMapper>(() =>
            mapperConfigurationDefaultHolder.Value.CreateMapper());
			/*
		private static Lazy<Natec.Entities.InsComparer> insComparer = 
			new Lazy<Natec.Entities.InsComparer>();
			*/
        #endregion

        #region [Properties]
		public static IMapper MapperDefault
		{
			get
			{
				return mapperDefaultHolder.Value;
			}
		}

		public static IMapper Mapper
		{
			get
			{
				return mapperHolder.Value;
			}
		}

        public static IMapper MapperWN
        {
            get
            {
                return mapperWNHolder.Value;
            }
        }

		public static MapperConfiguration Configuration
		{
			get
			{
				return mapperConfigurationHolder.Value;
			}
		}

        public static MapperConfiguration ConfigurationWN
        {
            get
            {
                return mapperConfigurationWNHolder.Value;
            }
        }

        public static MapperConfiguration ConfigurationDefault
        {
            get
            {
                return mapperConfigurationDefaultHolder.Value;
            }
        }

		public static MapperConfigurationExpression ConfigurationExpression
        {
            get
            {
                return mapperConfigurationExpressionHolder.Value;
            }
        }

        public static MapperConfigurationExpression ConfigurationWNExpression
        {
            get
            {
                return mapperConfigurationExpressionWNHolder.Value;
            }
        }

        public static MapperConfigurationExpression ConfigurationDefaultExpression
        {
            get
            {
                return mapperConfigurationExpressionDefaultHolder.Value;
            }
        }
        #endregion

        #region [Public]
		public static T Map<T>(object wm) where T:class
		{
			try
			{
				return Mapper.Map<T>(wm);
				//return (cfgType == 0)?Mapper.Map<T>(wm):MapperWN.Map<T>(wm);
			}
			catch(Exception e)
			{
				throw new UCP.Common.Plugin.CommonPlatformException(e.Message)
                {
                    Source = "MappingService"
                };
			}
		}

		public static T MapWN<T>(object wm) where T:class
		{
			try
			{
				return MapperWN.Map<T>(wm);
			}
			catch(Exception e)
			{
				throw new UCP.Common.Plugin.CommonPlatformException(e.Message)
                {
                    Source = "MappingService"
                };
			}
		}

		public static T MapDefault<T>(object wm) where T:class
		{
			try
			{
				return MapperDefault.Map<T>(wm);
			}
			catch(Exception e)
			{
				throw new UCP.Common.Plugin.CommonPlatformException(e.Message)
                {
                    Source = "MappingService"
                };
			}
		}

        public static TOut Map<T, TOut>(T wm, TOut existsInstance) where T : class
        {
            try
            {
                return Mapper.Map<T, TOut>(wm, existsInstance);
            }
            catch (Exception e)
            {
                throw new UCP.Common.Plugin.CommonPlatformException(e.Message)
                {
                    Source = "MappingService"
                };
            }
        }

        public static TOut MapWN<T, TOut>(T wm, TOut existsInstance) where T : class
        {
            try
            {
                return MapperWN.Map<T, TOut>(wm, existsInstance);
            }
            catch (Exception e)
            {
                throw new UCP.Common.Plugin.CommonPlatformException(e.Message)
                {
                    Source = "MappingService"
                };
            }
        }

        public static TOut MapDefault<T, TOut>(T wm, TOut existsInstance) where T : class
        {
            try
            {
                return MapperDefault.Map<T, TOut>(wm, existsInstance);
            }
            catch (Exception e)
            {
                throw new UCP.Common.Plugin.CommonPlatformException(e.Message)
                {
                    Source = "MappingService"
                };
            }
        }

        public static void ResetConfiguration(int cfgType)
        {
			/*
            mapperConfigurationHolder = new Lazy<MapperConfiguration>(() =>
                GetMapperConfiguration(cfgType));
				*/
        }

		public static MapperConfiguration GetMapperConfiguration(int cfgType)
		{
            MapperConfiguration result = null;
            if (cfgType == 0)
            {
                result = new MapperConfiguration(ConfigurationExpression);
            }
            else if (cfgType == 1)
            {
                result = new MapperConfiguration(ConfigurationWNExpression);
            }
			else
			{
				result = new MapperConfiguration(ConfigurationDefaultExpression);
			}

            result.CompileMappings();
			return result;
		}
        #endregion

		///////////////////////////////////////////////////////////////////////////
		/// Простая "дефолтная конфигруация"
		///////////////////////////////////////////////////////////////////////////
		public static MapperConfigurationExpression GetMapperConfigurationDefaultExpression()
		{
			throw new NotImplementedException();
		}

		////////////////////////////////////////////////////////////////
		// Конфигурация, где перезаписываются финальные значения вне зависимости от 
		// того, нул или не нул в модели - источнике
		////////////////////////////////////////////////////////////////
		public static MapperConfigurationExpression GetMapperConfigurationExpression()
		{
			MapperConfigurationExpression cfg = new MapperConfigurationExpression();
            return cfg;
        }

		////////////////////////////////////////////////////////////////
		// Конфигурация, где нулами НЕ перезаписываются финальные значения
		////////////////////////////////////////////////////////////////

		public static MapperConfigurationExpression GetMapperConfigurationWNExpression()
		{
			MapperConfigurationExpression cfg = new MapperConfigurationExpression();
            return cfg;
        }

    }
}


