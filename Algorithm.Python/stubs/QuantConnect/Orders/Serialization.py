# encoding: utf-8
# module QuantConnect.Orders.Serialization calls itself Serialization
# from QuantConnect.Common, Version=2.4.0.0, Culture=neutral, PublicKeyToken=null
# by generator 1.145
# no doc

# imports
import datetime
import QuantConnect.Orders
import QuantConnect.Orders.Serialization
import typing

# no functions
# classes

class OrderEventJsonConverter(QuantConnect.Util.TypeChangeJsonConverter[OrderEvent, SerializedOrderEvent]):
    """
    Defines how OrderEvents should be serialized to json
    
    OrderEventJsonConverter(algorithmId: str)
    """
    def __init__(self, algorithmId: str) -> QuantConnect.Orders.Serialization.OrderEventJsonConverter:
        pass



class SerializedOrder(System.object):
    """
    Data transfer object used for serializing an QuantConnect.Orders.Order that was just generated by an algorithm
    
    SerializedOrder(order: Order, algorithmId: str)
    """
    def __init__(self, order: QuantConnect.Orders.Order, algorithmId: str) -> QuantConnect.Orders.Serialization.SerializedOrder:
        pass

    AlgorithmId: str

    BrokerId: typing.List[str]

    CanceledTime: typing.Optional[float]

    ContingentId: int

    CreatedTime: float

    Direction: QuantConnect.Orders.OrderDirection

    Id: str

    LastFillTime: typing.Optional[float]

    LastUpdateTime: typing.Optional[float]

    LimitPrice: typing.Optional[float]

    OrderId: int

    Price: float

    PriceCurrency: str

    Quantity: float

    Status: QuantConnect.Orders.OrderStatus

    StopPrice: typing.Optional[float]

    StopTriggered: typing.Optional[bool]

    SubmissionAskPrice: float

    SubmissionBidPrice: float

    SubmissionLastPrice: float

    Symbol: str

    Tag: str

    TimeInForceExpiry: typing.Optional[float]

    TimeInForceType: str

    Type: QuantConnect.Orders.OrderType



class SerializedOrderEvent(System.object):
    """
    Data transfer object used for serializing an QuantConnect.Orders.OrderEvent that was just generated by an algorithm
    
    SerializedOrderEvent(orderEvent: OrderEvent, algorithmId: str)
    """
    def __init__(self, orderEvent: QuantConnect.Orders.OrderEvent, algorithmId: str) -> QuantConnect.Orders.Serialization.SerializedOrderEvent:
        pass

    AlgorithmId: str

    Direction: QuantConnect.Orders.OrderDirection

    FillPrice: float

    FillPriceCurrency: str

    FillQuantity: float

    Id: str

    IsAssignment: bool

    LimitPrice: typing.Optional[float]

    Message: str

    OrderEventId: int

    OrderFeeAmount: typing.Optional[float]

    OrderFeeCurrency: str

    OrderId: int

    Quantity: float

    Status: QuantConnect.Orders.OrderStatus

    StopPrice: typing.Optional[float]

    Symbol: str

    Time: float



class SerializedOrderJsonConverter(QuantConnect.Util.TypeChangeJsonConverter[Order, SerializedOrder]):
    """
    Defines how Orders should be serialized to json
    
    SerializedOrderJsonConverter(algorithmId: str)
    """
    def CanConvert(self, objectType: type) -> bool:
        pass

    def __init__(self, algorithmId: str) -> QuantConnect.Orders.Serialization.SerializedOrderJsonConverter:
        pass



