using System;

namespace DIP
{
    public class Repository
    {
        private ILogger _logger;
        public Repository(ILogger logger)
        {
            _logger = logger;
        }

        public void select()
        {
            try
            {
                throw new Exception();
            }
            catch (Exception ex)
            {

                _logger.Log(ex);
            }
        }
    }
}
