from .__Fundamental_58 import *
import typing
import System.IO
import System.Collections.Generic
import System
import QuantConnect.Data.Fundamental.MultiPeriodField
import QuantConnect.Data.Fundamental
import QuantConnect.Data
import QuantConnect
import datetime


class PurchaseofSubsidiariesCashFlowStatement(QuantConnect.Data.Fundamental.MultiPeriodField):
    """
    Purchase of subsidiaries or interest in subsidiaries (investments 51% and above).
    
    PurchaseofSubsidiariesCashFlowStatement(store: IDictionary[str, Decimal])
    """
    def GetPeriodValue(self, period: str) -> float:
        pass

    def SetPeriodValue(self, period: str, value: float) -> None:
        pass

    def __init__(self, store: System.Collections.Generic.IDictionary[str, float]) -> QuantConnect.Data.Fundamental.PurchaseofSubsidiariesCashFlowStatement:
        pass

    NineMonths: float

    SixMonths: float

    ThreeMonths: float

    TwelveMonths: float

    Store: typing.List[QuantConnect.Data.Fundamental.MultiPeriodField.PeriodField]


class QuickRatio(QuantConnect.Data.Fundamental.MultiPeriodField):
    """
    Refers to the ratio of liquid assets to Current Liabilities. Morningstar calculates the ratio by using the underlying data reported in the
                Balance Sheet within the company filings or reports:(Cash, Cash Equivalents, and Short Term Investments + Receivables ) /
                Current Liabilities.
    
    QuickRatio(store: IDictionary[str, Decimal])
    """
    def GetPeriodValue(self, period: str) -> float:
        pass

    def SetPeriodValue(self, period: str, value: float) -> None:
        pass

    def __init__(self, store: System.Collections.Generic.IDictionary[str, float]) -> QuantConnect.Data.Fundamental.QuickRatio:
        pass

    NineMonths: float

    OneMonth: float

    OneYear: float

    SixMonths: float

    ThreeMonths: float

    TwoMonths: float

    Store: typing.List[QuantConnect.Data.Fundamental.MultiPeriodField.PeriodField]


class RawMaterialsBalanceSheet(QuantConnect.Data.Fundamental.MultiPeriodField):
    """
    Carrying amount as of the balance sheet data of unprocessed items to be consumed in the manufacturing or production process.
                This item is available for manufacturing and mining industries.
    
    RawMaterialsBalanceSheet(store: IDictionary[str, Decimal])
    """
    def GetPeriodValue(self, period: str) -> float:
        pass

    def SetPeriodValue(self, period: str, value: float) -> None:
        pass

    def __init__(self, store: System.Collections.Generic.IDictionary[str, float]) -> QuantConnect.Data.Fundamental.RawMaterialsBalanceSheet:
        pass

    NineMonths: float

    SixMonths: float

    ThreeMonths: float

    TwelveMonths: float

    TwoMonths: float

    Store: typing.List[QuantConnect.Data.Fundamental.MultiPeriodField.PeriodField]


class RealizedGainLossOnSaleOfLoansAndLeaseCashFlowStatement(QuantConnect.Data.Fundamental.MultiPeriodField):
    """
    The gains and losses included in earnings that represent the difference between the sale price and the carrying value of loans and
                leases that were sold during the reporting PeriodAsByte. This element refers to the gain (loss) and not to the cash proceeds of the sales.
                This element is a non-cash adjustment to net income when calculating net cash generated by operating activities using the indirect
                method. This item is usually only available for bank industry.
    
    RealizedGainLossOnSaleOfLoansAndLeaseCashFlowStatement(store: IDictionary[str, Decimal])
    """
    def GetPeriodValue(self, period: str) -> float:
        pass

    def SetPeriodValue(self, period: str, value: float) -> None:
        pass

    def __init__(self, store: System.Collections.Generic.IDictionary[str, float]) -> QuantConnect.Data.Fundamental.RealizedGainLossOnSaleOfLoansAndLeaseCashFlowStatement:
        pass

    NineMonths: float

    OneMonth: float

    SixMonths: float

    ThreeMonths: float

    TwelveMonths: float

    Store: typing.List[QuantConnect.Data.Fundamental.MultiPeriodField.PeriodField]


class ReceiptsfromCustomersCashFlowStatement(QuantConnect.Data.Fundamental.MultiPeriodField):
    """
    Payment received from customers in the Direct Cash Flow.
    
    ReceiptsfromCustomersCashFlowStatement(store: IDictionary[str, Decimal])
    """
    def GetPeriodValue(self, period: str) -> float:
        pass

    def SetPeriodValue(self, period: str, value: float) -> None:
        pass

    def __init__(self, store: System.Collections.Generic.IDictionary[str, float]) -> QuantConnect.Data.Fundamental.ReceiptsfromCustomersCashFlowStatement:
        pass

    NineMonths: float

    SixMonths: float

    ThreeMonths: float

    TwelveMonths: float

    Store: typing.List[QuantConnect.Data.Fundamental.MultiPeriodField.PeriodField]


class ReceiptsfromGovernmentGrantsCashFlowStatement(QuantConnect.Data.Fundamental.MultiPeriodField):
    """
    Cash received from governments in the form of grants in the Direct Cash Flow.
    
    ReceiptsfromGovernmentGrantsCashFlowStatement(store: IDictionary[str, Decimal])
    """
    def GetPeriodValue(self, period: str) -> float:
        pass

    def SetPeriodValue(self, period: str, value: float) -> None:
        pass

    def __init__(self, store: System.Collections.Generic.IDictionary[str, float]) -> QuantConnect.Data.Fundamental.ReceiptsfromGovernmentGrantsCashFlowStatement:
        pass

    NineMonths: float

    SixMonths: float

    ThreeMonths: float

    TwelveMonths: float

    Store: typing.List[QuantConnect.Data.Fundamental.MultiPeriodField.PeriodField]


class ReceivablesAdjustmentsAllowancesBalanceSheet(QuantConnect.Data.Fundamental.MultiPeriodField):
    """
    A provision relating to a written agreement to receive money at a specified future date(s) (within one year from the reporting date
                or the normal operating cycle, whichever is longer), consisting of principal as well as any accrued interest).
    
    ReceivablesAdjustmentsAllowancesBalanceSheet(store: IDictionary[str, Decimal])
    """
    def GetPeriodValue(self, period: str) -> float:
        pass

    def SetPeriodValue(self, period: str, value: float) -> None:
        pass

    def __init__(self, store: System.Collections.Generic.IDictionary[str, float]) -> QuantConnect.Data.Fundamental.ReceivablesAdjustmentsAllowancesBalanceSheet:
        pass

    NineMonths: float

    ThreeMonths: float

    TwelveMonths: float

    Store: typing.List[QuantConnect.Data.Fundamental.MultiPeriodField.PeriodField]


class ReceivablesBalanceSheet(QuantConnect.Data.Fundamental.MultiPeriodField):
    """
    The sum of all receivables owed by customers and affiliates within one year, including accounts receivable, notes receivable,
                premiums receivable, and other current receivables.
    
    ReceivablesBalanceSheet(store: IDictionary[str, Decimal])
    """
    def GetPeriodValue(self, period: str) -> float:
        pass

    def SetPeriodValue(self, period: str, value: float) -> None:
        pass

    def __init__(self, store: System.Collections.Generic.IDictionary[str, float]) -> QuantConnect.Data.Fundamental.ReceivablesBalanceSheet:
        pass

    NineMonths: float

    OneMonth: float

    SixMonths: float

    ThreeMonths: float

    TwelveMonths: float

    TwoMonths: float

    Store: typing.List[QuantConnect.Data.Fundamental.MultiPeriodField.PeriodField]


class ReceivableTurnover(QuantConnect.Data.Fundamental.MultiPeriodField):
    """
    Revenue / Average Accounts Receivables
    
    ReceivableTurnover(store: IDictionary[str, Decimal])
    """
    def GetPeriodValue(self, period: str) -> float:
        pass

    def SetPeriodValue(self, period: str, value: float) -> None:
        pass

    def __init__(self, store: System.Collections.Generic.IDictionary[str, float]) -> QuantConnect.Data.Fundamental.ReceivableTurnover:
        pass

    OneYear: float

    SixMonths: float

    ThreeMonths: float

    Store: typing.List[QuantConnect.Data.Fundamental.MultiPeriodField.PeriodField]


class ReconciledCostOfRevenueIncomeStatement(QuantConnect.Data.Fundamental.MultiPeriodField):
    """
    The Cost Of Revenue plus Depreciation, Depletion & Amortization from the IncomeStatement; minus Depreciation, Depletion &
                Amortization from the Cash Flow Statement
    
    ReconciledCostOfRevenueIncomeStatement(store: IDictionary[str, Decimal])
    """
    def GetPeriodValue(self, period: str) -> float:
        pass

    def SetPeriodValue(self, period: str, value: float) -> None:
        pass

    def __init__(self, store: System.Collections.Generic.IDictionary[str, float]) -> QuantConnect.Data.Fundamental.ReconciledCostOfRevenueIncomeStatement:
        pass

    NineMonths: float

    OneMonth: float

    SixMonths: float

    ThreeMonths: float

    TwelveMonths: float

    TwoMonths: float

    Store: typing.List[QuantConnect.Data.Fundamental.MultiPeriodField.PeriodField]


class ReconciledDepreciationIncomeStatement(QuantConnect.Data.Fundamental.MultiPeriodField):
    """
    Is Depreciation, Depletion & Amortization from the Cash Flow Statement
    
    ReconciledDepreciationIncomeStatement(store: IDictionary[str, Decimal])
    """
    def GetPeriodValue(self, period: str) -> float:
        pass

    def SetPeriodValue(self, period: str, value: float) -> None:
        pass

    def __init__(self, store: System.Collections.Generic.IDictionary[str, float]) -> QuantConnect.Data.Fundamental.ReconciledDepreciationIncomeStatement:
        pass

    NineMonths: float

    OneMonth: float

    SixMonths: float

    ThreeMonths: float

    TwelveMonths: float

    TwoMonths: float

    Store: typing.List[QuantConnect.Data.Fundamental.MultiPeriodField.PeriodField]


class RegressionGrowthofDividends5Years(QuantConnect.Data.Fundamental.MultiPeriodField):
    """
    The five-year growth rate of dividends per share, calculated using regression analysis.
    
    RegressionGrowthofDividends5Years(store: IDictionary[str, Decimal])
    """
    def GetPeriodValue(self, period: str) -> float:
        pass

    def SetPeriodValue(self, period: str, value: float) -> None:
        pass

    def __init__(self, store: System.Collections.Generic.IDictionary[str, float]) -> QuantConnect.Data.Fundamental.RegressionGrowthofDividends5Years:
        pass

    FiveYears: float

    Store: typing.List[QuantConnect.Data.Fundamental.MultiPeriodField.PeriodField]
