namespace MigratedClientServices;

public static class TopicGenerator
{
    public static string TopicForClientInstrumentPrice(string instrument)
    {
        return "clientPrices." + instrument;
    }

    public static string TopicForMarketInstrumentPrice(string instrument)
    {
        return "marketPrices." + instrument;
    }

    public static string TopicForClientBuyOrder()
    {
        return "clientOrders.buyOrder";
    }

    public static string TopicForClientBuyOrderApproved()
    {
        return "clientOrders.buyOrderApproved";
    }

    public static string TopicForClientOrderEnded(string clientId)
    {
        return "clientOrders.buyOrderEnded" + clientId;
    }
    
    public static string TopicForLoginRequest()
    {
        return "loginRequest.loginRequested";
    }

    public static string TopicForLoginResponse()
    {
        return "loginRequest.loginResponded";
    }

    public static string TopicForAllClients()
    {
        return "StreamMisc.allClients";
    }

    public static string TopicForAllInstruments()
    {
        return "StreamMisc.allInstruments";
    }

    public static string TopicForBookingOrder()
    {
        return "clientOrders.BookOrder";
    }

    public static string TopicForHedgingOrder()
    {
        return "clientOrders.HedgeOrder";
    }
    public static string TopicForHedgingOrderRequest()
    {
        return "clientOrders.HedgeOrderRequest";
    }
    public static string TopicForHedgingOrderResponse()
    {
        return "clientOrders.HedgeOrderResponse";
    }

    public static string TopicForHoldingOfClient(string clientId)
    {
        return "StreamDBData.holdingOfClient" + clientId;
    }

    public static string TopicForDBDataOfClient(string clientId)
    {
        return "StreamDBData.dbDataOfClient" + clientId;
    }

    public static string TopicForAllTargetPositions()
    {
        return "StreamMisc.allTargetPositions";
    }

    public static string TopicForUpdateSimSpeed()
    {
        return "StreamMisc.updateSimSpeed";
    }

    public static string TopicForTargetPositionUpdate(string instrumentId)
    {
        return "StreamDBData.targetPositionUpdate" + instrumentId;
    }
    
}