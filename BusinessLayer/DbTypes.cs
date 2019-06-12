using System;

namespace BusinessLayer
{
	public static class DbTypes
	{
		#region public static int Int32FromByteArray(byte[] data, int sourceStartIndex)
		/// <summary>
		/// Извлекает из массива байт число типа <see cref="int"/>.
		/// Берёт значение младшего байта числа из нулевого элемента массива и т. д.
		/// </summary>
		/// <param name="data">Массив-источник</param>
		/// <param name="sourceStartIndex">Стартовый индекс массива с которого следует начинать копирование</param>
		/// <returns>Извлечённое число</returns>
		public static int Int32FromByteArray(byte[] data, int sourceStartIndex)
		{
			var typeSize = sizeof(int);
			const Int32 bitsInByte = 8;
			var result = 0;

			if (null == data) throw new ArgumentNullException("data", "Parameter must not be null");
			if (sizeof(int) + sourceStartIndex > data.Length) throw new ArgumentException("Copied length must be non less than " + typeSize);

			for (int i = 0; i < typeSize; i++)
				result |= data[i + sourceStartIndex] << (i * bitsInByte);

			return result;
		}
		#endregion

		#region public static Int64 Int64FromByteArray(byte[] data, int sourceStartIndex)

		public static Int64 Int64FromByteArray(byte[] data, int sourceStartIndex)
		{
			var typeSize = sizeof(Int64);
			const Int32 bitsInByte = 8;
			long result = 0;

			if (null == data) throw new ArgumentNullException("data", "Parameter must not be null");
			if (sizeof(long) + sourceStartIndex > data.Length) throw new ArgumentException("Copied length must be non less than " + typeSize);

			for (int i = 0; i < typeSize; i++)
				result |= (long)data[i + sourceStartIndex] << (i * bitsInByte);

			return result;
		}

		#endregion
	}
}