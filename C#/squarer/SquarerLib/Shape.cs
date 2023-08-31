namespace SquarerLib
{
    public abstract class Shape
    {
        /// <summary>
        /// Math the square
        /// </summary>
        public abstract double Square { get; }

        /// <summary>
        /// PI
        /// </summary>
        internal const double pi = 3.1415926535897931;

        /// <summary>
        /// Validate params. it mustn't be lower or eq 0
        /// </summary>
        /// <param name="payload"></param>
        /// <exception cref="SquarerException"></exception>
        internal virtual void ValidateParameter(params double[] payload)
        {
            string errorMessage = string.Empty;

            foreach (var v in payload)
                if (v <= 0) errorMessage += "Wrong arg: {0}; \n" + nameof(payload);

            if (errorMessage == string.Empty) return;

            throw new SquarerException(nameof(errorMessage));
        }
    }
}
