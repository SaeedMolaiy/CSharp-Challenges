namespace VowelsRemover
{
    internal class Exercise
    {
        private readonly char[] _chars = {
            'e','i','o','a','u',
              'E','I','O','A','U'
        };

        public string RemoveVowels(string value)
        {
            var lastSafeIndex = 0;

            for (var i = 0; i < value.Length; i++)
            {
                for (var j = 0; j < _chars.Length; j++)
                {
                    if (value[i] != _chars[j])
                    {
                        if (i == 0)
                        {
                            lastSafeIndex = i;
                        }
                        else
                        {
                            lastSafeIndex = i - 1;
                        }

                        continue;
                    }

                    j = 0;
                    value = value.Remove(i, 1);
                    i = lastSafeIndex;
                }
            }

            return value;
        }
    }
}