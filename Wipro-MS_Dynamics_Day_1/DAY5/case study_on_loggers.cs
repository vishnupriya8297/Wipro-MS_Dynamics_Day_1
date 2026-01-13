using System;

#region Custom Exceptions

// 1. Validation Exception (NO logging)
class ValidationException : Exception
{
    public ValidationException(string message) : base(message) { }
}

// 2. Business Rule Exception (log only if critical)
class BusinessRuleException : Exception
{
    public bool IsCritical { get; }

    public BusinessRuleException(string message, bool isCritical)
        : base(message)
    {
        IsCritical = isCritical;
    }
}

// 3. External Service Exception (ALWAYS log)
class ExternalServiceException : Exception
{
    public ExternalServiceException(string message) : base(message) { }
}

#endregion

#region Logger

class Logger
{
    public static void Log(Exception ex)
    {
        Console.WriteLine("---- LOG ENTRY ----");
        Console.WriteLine($"Time   : {DateTime.Now}");
        Console.WriteLine($"Type   : {ex.GetType().Name}");
        Console.WriteLine($"Message: {ex.Message}");
        Console.WriteLine("-------------------");
    }
}

#endregion

#region Business Logic

class OrderProcessor
{
    public void ProcessOrder(string userInput, int stock, bool paymentServiceUp)
    {
        // 1. User Input Validation
        if (string.IsNullOrWhiteSpace(userInput))
            throw new ValidationException("User input is invalid.");

        // 2. Business Rule Check
        if (stock <= 0)
            throw new BusinessRuleException("Insufficient stock.", isCritical: false);

        if (stock < 2)
            throw new BusinessRuleException("Stock critically low.", isCritical: true);

        // 3. External Service Call
        if (!paymentServiceUp)
            throw new ExternalServiceException("Payment service unavailable.");

        Console.WriteLine("Order processed successfully.");
    }
}

#endregion

#region Main Program

class Program
{
    static void Main(string[] args)
    {
        OrderProcessor processor = new OrderProcessor();

        try
        {
            // Change values here to test different scenarios
            processor.ProcessOrder(
                userInput: "ORDER123",
                stock: 1,                 // try 0, 1, or 10
                paymentServiceUp: true    // try false
            );
        }

        // ❌ Validation errors → NO logging
        catch (ValidationException)
        {
            Console.WriteLine("Validation failed. Please correct input.");
        }

        // ⚠️ Log ONLY critical business failures
        catch (BusinessRuleException ex) when (ex.IsCritical)
        {
            Logger.Log(ex);
            Console.WriteLine("Critical business issue handled.");
        }

        // ⚠️ Non-critical business failures → no logging
        catch (BusinessRuleException ex)
        {
            Console.WriteLine("Business rule violation: " + ex.Message);
        }

        // ✅ External service failures → ALWAYS log
        catch (ExternalServiceException ex)
        {
            Logger.Log(ex);
            Console.WriteLine("External service failure handled.");
        }

        // ✅ Unknown / system exceptions → ALWAYS log
        catch (Exception ex)
        {
            Logger.Log(ex);
            Console.WriteLine("Unexpected system error occurred.");
        }

        finally
        {
            Console.WriteLine("Order processing completed.");
        }
    }
}

#endregion
