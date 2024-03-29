from .__Fundamental_8 import *
import typing
import System.IO
import System.Collections.Generic
import System
import QuantConnect.Data.Fundamental.MultiPeriodField
import QuantConnect.Data.Fundamental
import QuantConnect.Data
import QuantConnect
import datetime


class CashFlowFromContinuingOperatingActivitiesCashFlowStatement(QuantConnect.Data.Fundamental.MultiPeriodField):
    """
    Cash generated by or used in operating activities of continuing operations; excludes cash flows from discontinued operations.
    
    CashFlowFromContinuingOperatingActivitiesCashFlowStatement(store: IDictionary[str, Decimal])
    """
    def GetPeriodValue(self, period: str) -> float:
        pass

    def SetPeriodValue(self, period: str, value: float) -> None:
        pass

    def __init__(self, store: System.Collections.Generic.IDictionary[str, float]) -> QuantConnect.Data.Fundamental.CashFlowFromContinuingOperatingActivitiesCashFlowStatement:
        pass

    NineMonths: float

    SixMonths: float

    ThreeMonths: float

    TwelveMonths: float

    TwoMonths: float

    Store: typing.List[QuantConnect.Data.Fundamental.MultiPeriodField.PeriodField]


class CashFlowFromDiscontinuedOperationCashFlowStatement(QuantConnect.Data.Fundamental.MultiPeriodField):
    """
    The aggregate amount of cash flow from discontinued operation, including operating activities, investing activities, and financing
                activities.
    
    CashFlowFromDiscontinuedOperationCashFlowStatement(store: IDictionary[str, Decimal])
    """
    def GetPeriodValue(self, period: str) -> float:
        pass

    def SetPeriodValue(self, period: str, value: float) -> None:
        pass

    def __init__(self, store: System.Collections.Generic.IDictionary[str, float]) -> QuantConnect.Data.Fundamental.CashFlowFromDiscontinuedOperationCashFlowStatement:
        pass

    NineMonths: float

    SixMonths: float

    ThreeMonths: float

    TwelveMonths: float

    Store: typing.List[QuantConnect.Data.Fundamental.MultiPeriodField.PeriodField]


class CashFlowfromFinancingGrowth(QuantConnect.Data.Fundamental.MultiPeriodField):
    """
    The growth in the company's cash flows from financing on a percentage basis. Morningstar calculates the growth percentage
                based on the financing cash flows reported in the Cash Flow Statement within the company filings or reports.
    
    CashFlowfromFinancingGrowth(store: IDictionary[str, Decimal])
    """
    def GetPeriodValue(self, period: str) -> float:
        pass

    def SetPeriodValue(self, period: str, value: float) -> None:
        pass

    def __init__(self, store: System.Collections.Generic.IDictionary[str, float]) -> QuantConnect.Data.Fundamental.CashFlowfromFinancingGrowth:
        pass

    FiveYears: float

    OneYear: float

    ThreeYears: float

    Store: typing.List[QuantConnect.Data.Fundamental.MultiPeriodField.PeriodField]


class CashFlowfromInvestingGrowth(QuantConnect.Data.Fundamental.MultiPeriodField):
    """
    The growth in the company's cash flows from investing on a percentage basis. Morningstar calculates the growth percentage
                based on the cash flows from investing reported in the Cash Flow Statement within the company filings or reports.
    
    CashFlowfromInvestingGrowth(store: IDictionary[str, Decimal])
    """
    def GetPeriodValue(self, period: str) -> float:
        pass

    def SetPeriodValue(self, period: str, value: float) -> None:
        pass

    def __init__(self, store: System.Collections.Generic.IDictionary[str, float]) -> QuantConnect.Data.Fundamental.CashFlowfromInvestingGrowth:
        pass

    FiveYears: float

    OneYear: float

    ThreeYears: float

    Store: typing.List[QuantConnect.Data.Fundamental.MultiPeriodField.PeriodField]


class CashFlowsfromusedinOperatingActivitiesDirectCashFlowStatement(QuantConnect.Data.Fundamental.MultiPeriodField):
    """
    The net cash from (used in) all of the entity's operating activities, including those of discontinued operations, of the reporting entity
                under the direct method.
    
    CashFlowsfromusedinOperatingActivitiesDirectCashFlowStatement(store: IDictionary[str, Decimal])
    """
    def GetPeriodValue(self, period: str) -> float:
        pass

    def SetPeriodValue(self, period: str, value: float) -> None:
        pass

    def __init__(self, store: System.Collections.Generic.IDictionary[str, float]) -> QuantConnect.Data.Fundamental.CashFlowsfromusedinOperatingActivitiesDirectCashFlowStatement:
        pass

    NineMonths: float

    OneMonth: float

    SixMonths: float

    ThreeMonths: float

    TwelveMonths: float

    Store: typing.List[QuantConnect.Data.Fundamental.MultiPeriodField.PeriodField]


class CashFlowStatement(System.object):
    """
    Definition of the CashFlowStatement class
    
    CashFlowStatement()
    """
    def UpdateValues(self, update: QuantConnect.Data.Fundamental.CashFlowStatement) -> None:
        pass

    AllTaxesPaid: QuantConnect.Data.Fundamental.AllTaxesPaidCashFlowStatement

    Amortization: QuantConnect.Data.Fundamental.AmortizationCashFlowStatement

    AmortizationOfFinancingCostsAndDiscounts: QuantConnect.Data.Fundamental.AmortizationOfFinancingCostsAndDiscountsCashFlowStatement

    AmortizationOfIntangibles: QuantConnect.Data.Fundamental.AmortizationOfIntangiblesCashFlowStatement

    AmortizationOfSecurities: QuantConnect.Data.Fundamental.AmortizationOfSecuritiesCashFlowStatement

    AssetImpairmentCharge: QuantConnect.Data.Fundamental.AssetImpairmentChargeCashFlowStatement

    BeginningCashPosition: QuantConnect.Data.Fundamental.BeginningCashPositionCashFlowStatement

    CapExReported: QuantConnect.Data.Fundamental.CapExReportedCashFlowStatement

    CapitalExpenditure: QuantConnect.Data.Fundamental.CapitalExpenditureCashFlowStatement

    CashAdvancesandLoansMadetoOtherParties: QuantConnect.Data.Fundamental.CashAdvancesandLoansMadetoOtherPartiesCashFlowStatement

    CashDividendsForMinorities: QuantConnect.Data.Fundamental.CashDividendsForMinoritiesCashFlowStatement

    CashDividendsPaid: QuantConnect.Data.Fundamental.CashDividendsPaidCashFlowStatement

    CashFlowFromContinuingFinancingActivities: QuantConnect.Data.Fundamental.CashFlowFromContinuingFinancingActivitiesCashFlowStatement

    CashFlowFromContinuingInvestingActivities: QuantConnect.Data.Fundamental.CashFlowFromContinuingInvestingActivitiesCashFlowStatement

    CashFlowFromContinuingOperatingActivities: QuantConnect.Data.Fundamental.CashFlowFromContinuingOperatingActivitiesCashFlowStatement

    CashFlowFromDiscontinuedOperation: QuantConnect.Data.Fundamental.CashFlowFromDiscontinuedOperationCashFlowStatement

    CashFlowsfromusedinOperatingActivitiesDirect: QuantConnect.Data.Fundamental.CashFlowsfromusedinOperatingActivitiesDirectCashFlowStatement

    CashFromDiscontinuedFinancing: QuantConnect.Data.Fundamental.CashFromDiscontinuedFinancingCashFlowStatement

    CashFromDiscontinuedFinancingActivities: QuantConnect.Data.Fundamental.CashFromDiscontinuedFinancingActivitiesCashFlowStatement

    CashFromDiscontinuedInvesting: QuantConnect.Data.Fundamental.CashFromDiscontinuedInvestingCashFlowStatement

    CashFromDiscontinuedInvestingActivities: QuantConnect.Data.Fundamental.CashFromDiscontinuedInvestingActivitiesCashFlowStatement

    CashFromDiscontinuedOperating: QuantConnect.Data.Fundamental.CashFromDiscontinuedOperatingCashFlowStatement

    CashFromDiscontinuedOperatingActivities: QuantConnect.Data.Fundamental.CashFromDiscontinuedOperatingActivitiesCashFlowStatement

    CashGeneratedfromOperatingActivities: QuantConnect.Data.Fundamental.CashGeneratedfromOperatingActivitiesCashFlowStatement

    CashPaidforInsuranceActivities: QuantConnect.Data.Fundamental.CashPaidforInsuranceActivitiesCashFlowStatement

    CashPaidtoReinsurers: QuantConnect.Data.Fundamental.CashPaidtoReinsurersCashFlowStatement

    CashPaymentsforDepositsbyBanksandCustomers: QuantConnect.Data.Fundamental.CashPaymentsforDepositsbyBanksandCustomersCashFlowStatement

    CashPaymentsforLoans: QuantConnect.Data.Fundamental.CashPaymentsforLoansCashFlowStatement

    CashReceiptsfromDepositsbyBanksandCustomers: QuantConnect.Data.Fundamental.CashReceiptsfromDepositsbyBanksandCustomersCashFlowStatement

    CashReceiptsfromFeesandCommissions: QuantConnect.Data.Fundamental.CashReceiptsfromFeesandCommissionsCashFlowStatement

    CashReceiptsfromLoans: QuantConnect.Data.Fundamental.CashReceiptsfromLoansCashFlowStatement

    CashReceiptsfromRepaymentofAdvancesandLoansMadetoOtherParties: QuantConnect.Data.Fundamental.CashReceiptsfromRepaymentofAdvancesandLoansMadetoOtherPartiesCashFlowStatement

    CashReceiptsfromSecuritiesRelatedActivities: QuantConnect.Data.Fundamental.CashReceiptsfromSecuritiesRelatedActivitiesCashFlowStatement

    CashReceiptsfromTaxRefunds: QuantConnect.Data.Fundamental.CashReceiptsfromTaxRefundsCashFlowStatement

    CashReceivedfromInsuranceActivities: QuantConnect.Data.Fundamental.CashReceivedfromInsuranceActivitiesCashFlowStatement

    CFFileDate: datetime.datetime

    ChangeInAccountPayable: QuantConnect.Data.Fundamental.ChangeInAccountPayableCashFlowStatement

    ChangeInAccruedExpense: QuantConnect.Data.Fundamental.ChangeInAccruedExpenseCashFlowStatement

    ChangeinAccruedIncome: QuantConnect.Data.Fundamental.ChangeinAccruedIncomeCashFlowStatement

    ChangeInAccruedInvestmentIncome: QuantConnect.Data.Fundamental.ChangeInAccruedInvestmentIncomeCashFlowStatement

    ChangeinAdvancesfromCentralBanks: QuantConnect.Data.Fundamental.ChangeinAdvancesfromCentralBanksCashFlowStatement

    ChangeinCashSupplementalAsReported: QuantConnect.Data.Fundamental.ChangeinCashSupplementalAsReportedCashFlowStatement

    ChangeInDeferredAcquisitionCosts: QuantConnect.Data.Fundamental.ChangeInDeferredAcquisitionCostsCashFlowStatement

    ChangeinDeferredAcquisitionCostsNet: QuantConnect.Data.Fundamental.ChangeinDeferredAcquisitionCostsNetCashFlowStatement

    ChangeInDeferredCharges: QuantConnect.Data.Fundamental.ChangeInDeferredChargesCashFlowStatement

    ChangeinDepositsbyBanksandCustomers: QuantConnect.Data.Fundamental.ChangeinDepositsbyBanksandCustomersCashFlowStatement

    ChangeInDividendPayable: QuantConnect.Data.Fundamental.ChangeInDividendPayableCashFlowStatement

    ChangeInFederalFundsAndSecuritiesSoldForRepurchase: QuantConnect.Data.Fundamental.ChangeInFederalFundsAndSecuritiesSoldForRepurchaseCashFlowStatement

    ChangeinFinancialAssets: QuantConnect.Data.Fundamental.ChangeinFinancialAssetsCashFlowStatement

    ChangeinFinancialLiabilities: QuantConnect.Data.Fundamental.ChangeinFinancialLiabilitiesCashFlowStatement

    ChangeInFundsWithheld: QuantConnect.Data.Fundamental.ChangeInFundsWithheldCashFlowStatement

    ChangeInIncomeTaxPayable: QuantConnect.Data.Fundamental.ChangeInIncomeTaxPayableCashFlowStatement

    ChangeinInsuranceContractAssets: QuantConnect.Data.Fundamental.ChangeinInsuranceContractAssetsCashFlowStatement

    ChangeinInsuranceContractLiabilities: QuantConnect.Data.Fundamental.ChangeinInsuranceContractLiabilitiesCashFlowStatement

    ChangeinInsuranceFunds: QuantConnect.Data.Fundamental.ChangeinInsuranceFundsCashFlowStatement

    ChangeInInterestPayable: QuantConnect.Data.Fundamental.ChangeInInterestPayableCashFlowStatement

    ChangeInInventory: QuantConnect.Data.Fundamental.ChangeInInventoryCashFlowStatement

    ChangeinInvestmentContractLiabilities: QuantConnect.Data.Fundamental.ChangeinInvestmentContractLiabilitiesCashFlowStatement

    ChangeInLoans: QuantConnect.Data.Fundamental.ChangeInLoansCashFlowStatement

    ChangeInLossAndLossAdjustmentExpenseReserves: QuantConnect.Data.Fundamental.ChangeInLossAndLossAdjustmentExpenseReservesCashFlowStatement

    ChangeInOtherCurrentAssets: QuantConnect.Data.Fundamental.ChangeInOtherCurrentAssetsCashFlowStatement

    ChangeInOtherCurrentLiabilities: QuantConnect.Data.Fundamental.ChangeInOtherCurrentLiabilitiesCashFlowStatement

    ChangeInOtherWorkingCapital: QuantConnect.Data.Fundamental.ChangeInOtherWorkingCapitalCashFlowStatement

    ChangeInPayable: QuantConnect.Data.Fundamental.ChangeInPayableCashFlowStatement

    ChangeInPayablesAndAccruedExpense: QuantConnect.Data.Fundamental.ChangeInPayablesAndAccruedExpenseCashFlowStatement

    ChangeInPrepaidAssets: QuantConnect.Data.Fundamental.ChangeInPrepaidAssetsCashFlowStatement

    ChangeInReceivables: QuantConnect.Data.Fundamental.ChangeInReceivablesCashFlowStatement

    ChangeinReinsuranceReceivables: QuantConnect.Data.Fundamental.ChangeinReinsuranceReceivablesCashFlowStatement

    ChangeInReinsuranceRecoverableOnPaidAndUnpaidLosses: QuantConnect.Data.Fundamental.ChangeInReinsuranceRecoverableOnPaidAndUnpaidLossesCashFlowStatement

    ChangeInRestrictedCash: QuantConnect.Data.Fundamental.ChangeInRestrictedCashCashFlowStatement

    ChangeInTaxPayable: QuantConnect.Data.Fundamental.ChangeInTaxPayableCashFlowStatement

    ChangeInTradingAccountSecurities: QuantConnect.Data.Fundamental.ChangeInTradingAccountSecuritiesCashFlowStatement

    ChangeInUnearnedPremiums: QuantConnect.Data.Fundamental.ChangeInUnearnedPremiumsCashFlowStatement

    ChangeInWorkingCapital: QuantConnect.Data.Fundamental.ChangeInWorkingCapitalCashFlowStatement

    ChangesInAccountReceivables: QuantConnect.Data.Fundamental.ChangesInAccountReceivablesCashFlowStatement

    ChangesInCash: QuantConnect.Data.Fundamental.ChangesInCashCashFlowStatement

    ClaimsPaid: QuantConnect.Data.Fundamental.ClaimsPaidCashFlowStatement

    ClassesofCashPayments: QuantConnect.Data.Fundamental.ClassesofCashPaymentsCashFlowStatement

    ClassesofCashReceiptsfromOperatingActivities: QuantConnect.Data.Fundamental.ClassesofCashReceiptsfromOperatingActivitiesCashFlowStatement

    CommissionPaid: QuantConnect.Data.Fundamental.CommissionPaidCashFlowStatement

    CommonStockDividendPaid: QuantConnect.Data.Fundamental.CommonStockDividendPaidCashFlowStatement

    CommonStockIssuance: QuantConnect.Data.Fundamental.CommonStockIssuanceCashFlowStatement

    CommonStockPayments: QuantConnect.Data.Fundamental.CommonStockPaymentsCashFlowStatement

    DecreaseinInterestBearingDepositsinBank: QuantConnect.Data.Fundamental.DecreaseinInterestBearingDepositsinBankCashFlowStatement

    DeferredIncomeTax: QuantConnect.Data.Fundamental.DeferredIncomeTaxCashFlowStatement

    DeferredTax: QuantConnect.Data.Fundamental.DeferredTaxCashFlowStatement

    Depletion: QuantConnect.Data.Fundamental.DepletionCashFlowStatement

    Depreciation: QuantConnect.Data.Fundamental.DepreciationCashFlowStatement

    DepreciationAmortizationDepletion: QuantConnect.Data.Fundamental.DepreciationAmortizationDepletionCashFlowStatement

    DepreciationAndAmortization: QuantConnect.Data.Fundamental.DepreciationAndAmortizationCashFlowStatement

    DividendPaidCFO: QuantConnect.Data.Fundamental.DividendPaidCFOCashFlowStatement

    DividendReceivedCFO: QuantConnect.Data.Fundamental.DividendReceivedCFOCashFlowStatement

    DividendsPaidDirect: QuantConnect.Data.Fundamental.DividendsPaidDirectCashFlowStatement

    DividendsReceivedCFI: QuantConnect.Data.Fundamental.DividendsReceivedCFICashFlowStatement

    DividendsReceivedDirect: QuantConnect.Data.Fundamental.DividendsReceivedDirectCashFlowStatement

    EarningsLossesFromEquityInvestments: QuantConnect.Data.Fundamental.EarningsLossesFromEquityInvestmentsCashFlowStatement

    EffectOfExchangeRateChanges: QuantConnect.Data.Fundamental.EffectOfExchangeRateChangesCashFlowStatement

    EndCashPosition: QuantConnect.Data.Fundamental.EndCashPositionCashFlowStatement

    ExcessTaxBenefitFromStockBasedCompensation: QuantConnect.Data.Fundamental.ExcessTaxBenefitFromStockBasedCompensationCashFlowStatement

    FinancingCashFlow: QuantConnect.Data.Fundamental.FinancingCashFlowCashFlowStatement

    FreeCashFlow: QuantConnect.Data.Fundamental.FreeCashFlowCashFlowStatement

    FundFromOperation: QuantConnect.Data.Fundamental.FundFromOperationCashFlowStatement

    GainLossOnInvestmentSecurities: QuantConnect.Data.Fundamental.GainLossOnInvestmentSecuritiesCashFlowStatement

    GainLossOnSaleOfBusiness: QuantConnect.Data.Fundamental.GainLossOnSaleOfBusinessCashFlowStatement

    GainLossOnSaleOfPPE: QuantConnect.Data.Fundamental.GainLossOnSaleOfPPECashFlowStatement

    ImpairmentLossReversalRecognizedinProfitorLoss: QuantConnect.Data.Fundamental.ImpairmentLossReversalRecognizedinProfitorLossCashFlowStatement

    IncomeTaxPaidSupplementalData: QuantConnect.Data.Fundamental.IncomeTaxPaidSupplementalDataCashFlowStatement

    IncreaseDecreaseInDeposit: QuantConnect.Data.Fundamental.IncreaseDecreaseInDepositCashFlowStatement

    IncreaseDecreaseinLeaseFinancing: QuantConnect.Data.Fundamental.IncreaseDecreaseinLeaseFinancingCashFlowStatement

    IncreaseinInterestBearingDepositsinBank: QuantConnect.Data.Fundamental.IncreaseinInterestBearingDepositsinBankCashFlowStatement

    IncreaseinLeaseFinancing: QuantConnect.Data.Fundamental.IncreaseinLeaseFinancingCashFlowStatement

    InterestandCommissionPaid: QuantConnect.Data.Fundamental.InterestandCommissionPaidCashFlowStatement

    InterestCreditedOnPolicyholderDeposits: QuantConnect.Data.Fundamental.InterestCreditedOnPolicyholderDepositsCashFlowStatement

    InterestPaidCFF: QuantConnect.Data.Fundamental.InterestPaidCFFCashFlowStatement

    InterestPaidCFO: QuantConnect.Data.Fundamental.InterestPaidCFOCashFlowStatement

    InterestPaidDirect: QuantConnect.Data.Fundamental.InterestPaidDirectCashFlowStatement

    InterestPaidSupplementalData: QuantConnect.Data.Fundamental.InterestPaidSupplementalDataCashFlowStatement

    InterestReceivedCFI: QuantConnect.Data.Fundamental.InterestReceivedCFICashFlowStatement

    InterestReceivedCFO: QuantConnect.Data.Fundamental.InterestReceivedCFOCashFlowStatement

    InterestReceivedDirect: QuantConnect.Data.Fundamental.InterestReceivedDirectCashFlowStatement

    InvestingCashFlow: QuantConnect.Data.Fundamental.InvestingCashFlowCashFlowStatement

    IssuanceOfCapitalStock: QuantConnect.Data.Fundamental.IssuanceOfCapitalStockCashFlowStatement

    IssuanceOfDebt: QuantConnect.Data.Fundamental.IssuanceOfDebtCashFlowStatement

    IssueExpenses: QuantConnect.Data.Fundamental.IssueExpensesCashFlowStatement

    LongTermDebtIssuance: QuantConnect.Data.Fundamental.LongTermDebtIssuanceCashFlowStatement

    LongTermDebtPayments: QuantConnect.Data.Fundamental.LongTermDebtPaymentsCashFlowStatement

    MinorityInterest: QuantConnect.Data.Fundamental.MinorityInterestCashFlowStatement

    NetBusinessPurchaseAndSale: QuantConnect.Data.Fundamental.NetBusinessPurchaseAndSaleCashFlowStatement

    NetCashFromDiscontinuedOperations: QuantConnect.Data.Fundamental.NetCashFromDiscontinuedOperationsCashFlowStatement

    NetCommonStockIssuance: QuantConnect.Data.Fundamental.NetCommonStockIssuanceCashFlowStatement

    NetForeignCurrencyExchangeGainLoss: QuantConnect.Data.Fundamental.NetForeignCurrencyExchangeGainLossCashFlowStatement

    NetIncomeFromContinuingOperations: QuantConnect.Data.Fundamental.NetIncomeFromContinuingOperationsCashFlowStatement

    NetIntangiblesPurchaseAndSale: QuantConnect.Data.Fundamental.NetIntangiblesPurchaseAndSaleCashFlowStatement

    NetInvestmentPropertiesPurchaseAndSale: QuantConnect.Data.Fundamental.NetInvestmentPropertiesPurchaseAndSaleCashFlowStatement

    NetInvestmentPurchaseAndSale: QuantConnect.Data.Fundamental.NetInvestmentPurchaseAndSaleCashFlowStatement

    NetIssuancePaymentsOfDebt: QuantConnect.Data.Fundamental.NetIssuancePaymentsOfDebtCashFlowStatement

    NetLongTermDebtIssuance: QuantConnect.Data.Fundamental.NetLongTermDebtIssuanceCashFlowStatement

    NetOtherFinancingCharges: QuantConnect.Data.Fundamental.NetOtherFinancingChargesCashFlowStatement

    NetOtherInvestingChanges: QuantConnect.Data.Fundamental.NetOtherInvestingChangesCashFlowStatement

    NetOutwardLoans: QuantConnect.Data.Fundamental.NetOutwardLoansCashFlowStatement

    NetPPEPurchaseAndSale: QuantConnect.Data.Fundamental.NetPPEPurchaseAndSaleCashFlowStatement

    NetPreferredStockIssuance: QuantConnect.Data.Fundamental.NetPreferredStockIssuanceCashFlowStatement

    NetProceedsPaymentForLoan: QuantConnect.Data.Fundamental.NetProceedsPaymentForLoanCashFlowStatement

    NetShortTermDebtIssuance: QuantConnect.Data.Fundamental.NetShortTermDebtIssuanceCashFlowStatement

    OperatingCashFlow: QuantConnect.Data.Fundamental.OperatingCashFlowCashFlowStatement

    OperatingGainsLosses: QuantConnect.Data.Fundamental.OperatingGainsLossesCashFlowStatement

    OtherCashAdjustExcludeFromChangeinCash: QuantConnect.Data.Fundamental.OtherCashAdjustExcludeFromChangeinCashCashFlowStatement

    OtherCashAdjustIncludedIntoChangeinCash: QuantConnect.Data.Fundamental.OtherCashAdjustIncludedIntoChangeinCashCashFlowStatement

    OtherCashPaymentsfromOperatingActivities: QuantConnect.Data.Fundamental.OtherCashPaymentsfromOperatingActivitiesCashFlowStatement

    OtherCashReceiptsfromOperatingActivities: QuantConnect.Data.Fundamental.OtherCashReceiptsfromOperatingActivitiesCashFlowStatement

    OtherNonCashItems: QuantConnect.Data.Fundamental.OtherNonCashItemsCashFlowStatement

    OtherOperatingInflowsOutflowsofCash: QuantConnect.Data.Fundamental.OtherOperatingInflowsOutflowsofCashCashFlowStatement

    OtherUnderwritingExpensesPaid: QuantConnect.Data.Fundamental.OtherUnderwritingExpensesPaidCashFlowStatement

    PaymentForLoans: QuantConnect.Data.Fundamental.PaymentForLoansCashFlowStatement

    PaymentsonBehalfofEmployees: QuantConnect.Data.Fundamental.PaymentsonBehalfofEmployeesCashFlowStatement

    PaymentstoSuppliersforGoodsandServices: QuantConnect.Data.Fundamental.PaymentstoSuppliersforGoodsandServicesCashFlowStatement

    PensionAndEmployeeBenefitExpense: QuantConnect.Data.Fundamental.PensionAndEmployeeBenefitExpenseCashFlowStatement

    PolicyholderDepositInvestmentReceived: QuantConnect.Data.Fundamental.PolicyholderDepositInvestmentReceivedCashFlowStatement

    PreferredStockDividendPaid: QuantConnect.Data.Fundamental.PreferredStockDividendPaidCashFlowStatement

    PreferredStockIssuance: QuantConnect.Data.Fundamental.PreferredStockIssuanceCashFlowStatement

    PreferredStockPayments: QuantConnect.Data.Fundamental.PreferredStockPaymentsCashFlowStatement

    PremiumReceived: QuantConnect.Data.Fundamental.PremiumReceivedCashFlowStatement

    ProceedsFromLoans: QuantConnect.Data.Fundamental.ProceedsFromLoansCashFlowStatement

    ProceedsFromStockOptionExercised: QuantConnect.Data.Fundamental.ProceedsFromStockOptionExercisedCashFlowStatement

    ProceedsPaymentFederalFundsSoldAndSecuritiesPurchasedUnderAgreementToResell: QuantConnect.Data.Fundamental.ProceedsPaymentFederalFundsSoldAndSecuritiesPurchasedUnderAgreementToResellCashFlowStatement

    ProceedsPaymentInInterestBearingDepositsInBank: QuantConnect.Data.Fundamental.ProceedsPaymentInInterestBearingDepositsInBankCashFlowStatement

    ProfitonDisposals: QuantConnect.Data.Fundamental.ProfitonDisposalsCashFlowStatement

    ProvisionandWriteOffofAssets: QuantConnect.Data.Fundamental.ProvisionandWriteOffofAssetsCashFlowStatement

    ProvisionForLoanLeaseAndOtherLosses: QuantConnect.Data.Fundamental.ProvisionForLoanLeaseAndOtherLossesCashFlowStatement

    PurchaseOfBusiness: QuantConnect.Data.Fundamental.PurchaseOfBusinessCashFlowStatement

    PurchaseOfIntangibles: QuantConnect.Data.Fundamental.PurchaseOfIntangiblesCashFlowStatement

    PurchaseOfInvestment: QuantConnect.Data.Fundamental.PurchaseOfInvestmentCashFlowStatement

    PurchaseOfInvestmentProperties: QuantConnect.Data.Fundamental.PurchaseOfInvestmentPropertiesCashFlowStatement

    PurchaseofJointVentureAssociate: QuantConnect.Data.Fundamental.PurchaseofJointVentureAssociateCashFlowStatement

    PurchaseOfPPE: QuantConnect.Data.Fundamental.PurchaseOfPPECashFlowStatement

    PurchaseofSubsidiaries: QuantConnect.Data.Fundamental.PurchaseofSubsidiariesCashFlowStatement

    RealizedGainLossOnSaleOfLoansAndLease: QuantConnect.Data.Fundamental.RealizedGainLossOnSaleOfLoansAndLeaseCashFlowStatement

    ReceiptsfromCustomers: QuantConnect.Data.Fundamental.ReceiptsfromCustomersCashFlowStatement

    ReceiptsfromGovernmentGrants: QuantConnect.Data.Fundamental.ReceiptsfromGovernmentGrantsCashFlowStatement

    ReinsuranceandOtherRecoveriesReceived: QuantConnect.Data.Fundamental.ReinsuranceandOtherRecoveriesReceivedCashFlowStatement

    ReorganizationOtherCosts: QuantConnect.Data.Fundamental.ReorganizationOtherCostsCashFlowStatement

    RepaymentinLeaseFinancing: QuantConnect.Data.Fundamental.RepaymentinLeaseFinancingCashFlowStatement

    RepaymentOfDebt: QuantConnect.Data.Fundamental.RepaymentOfDebtCashFlowStatement

    RepurchaseOfCapitalStock: QuantConnect.Data.Fundamental.RepurchaseOfCapitalStockCashFlowStatement

    SaleOfBusiness: QuantConnect.Data.Fundamental.SaleOfBusinessCashFlowStatement

    SaleOfIntangibles: QuantConnect.Data.Fundamental.SaleOfIntangiblesCashFlowStatement

    SaleOfInvestment: QuantConnect.Data.Fundamental.SaleOfInvestmentCashFlowStatement

    SaleOfInvestmentProperties: QuantConnect.Data.Fundamental.SaleOfInvestmentPropertiesCashFlowStatement

    SaleofJointVentureAssociate: QuantConnect.Data.Fundamental.SaleofJointVentureAssociateCashFlowStatement

    SaleOfPPE: QuantConnect.Data.Fundamental.SaleOfPPECashFlowStatement

    SaleofSubsidiaries: QuantConnect.Data.Fundamental.SaleofSubsidiariesCashFlowStatement

    ShareofAssociates: QuantConnect.Data.Fundamental.ShareofAssociatesCashFlowStatement

    ShortTermDebtIssuance: QuantConnect.Data.Fundamental.ShortTermDebtIssuanceCashFlowStatement

    ShortTermDebtPayments: QuantConnect.Data.Fundamental.ShortTermDebtPaymentsCashFlowStatement

    StockBasedCompensation: QuantConnect.Data.Fundamental.StockBasedCompensationCashFlowStatement

    TaxesRefundPaid: QuantConnect.Data.Fundamental.TaxesRefundPaidCashFlowStatement

    TaxesRefundPaidDirect: QuantConnect.Data.Fundamental.TaxesRefundPaidDirectCashFlowStatement

    TotalAdjustmentsforNonCashItems: QuantConnect.Data.Fundamental.TotalAdjustmentsforNonCashItemsCashFlowStatement

    UnrealizedGainLossOnInvestmentSecurities: QuantConnect.Data.Fundamental.UnrealizedGainLossOnInvestmentSecuritiesCashFlowStatement

    UnrealizedGainsLossesOnDerivatives: QuantConnect.Data.Fundamental.UnrealizedGainsLossesOnDerivativesCashFlowStatement
