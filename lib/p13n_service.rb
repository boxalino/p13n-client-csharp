#
# Autogenerated by Thrift Compiler (0.9.2)
#
# DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
#

require 'thrift'
require 'p13n_types'

module P13nService
  class Client
    include ::Thrift::Client

    def choose(choiceRequest)
      send_choose(choiceRequest)
      return recv_choose()
    end

    def send_choose(choiceRequest)
      send_message('choose', Choose_args, :choiceRequest => choiceRequest)
    end

    def recv_choose()
      result = receive_message(Choose_result)
      return result.success unless result.success.nil?
      raise result.p13nServiceException unless result.p13nServiceException.nil?
      raise ::Thrift::ApplicationException.new(::Thrift::ApplicationException::MISSING_RESULT, 'choose failed: unknown result')
    end

    def batchChoose(batchChoiceRequest)
      send_batchChoose(batchChoiceRequest)
      return recv_batchChoose()
    end

    def send_batchChoose(batchChoiceRequest)
      send_message('batchChoose', BatchChoose_args, :batchChoiceRequest => batchChoiceRequest)
    end

    def recv_batchChoose()
      result = receive_message(BatchChoose_result)
      return result.success unless result.success.nil?
      raise result.p13nServiceException unless result.p13nServiceException.nil?
      raise ::Thrift::ApplicationException.new(::Thrift::ApplicationException::MISSING_RESULT, 'batchChoose failed: unknown result')
    end

    def autocomplete(request)
      send_autocomplete(request)
      return recv_autocomplete()
    end

    def send_autocomplete(request)
      send_message('autocomplete', Autocomplete_args, :request => request)
    end

    def recv_autocomplete()
      result = receive_message(Autocomplete_result)
      return result.success unless result.success.nil?
      raise result.p13nServiceException unless result.p13nServiceException.nil?
      raise ::Thrift::ApplicationException.new(::Thrift::ApplicationException::MISSING_RESULT, 'autocomplete failed: unknown result')
    end

  end

  class Processor
    include ::Thrift::Processor

    def process_choose(seqid, iprot, oprot)
      args = read_args(iprot, Choose_args)
      result = Choose_result.new()
      begin
        result.success = @handler.choose(args.choiceRequest)
      rescue ::P13nServiceException => p13nServiceException
        result.p13nServiceException = p13nServiceException
      end
      write_result(result, oprot, 'choose', seqid)
    end

    def process_batchChoose(seqid, iprot, oprot)
      args = read_args(iprot, BatchChoose_args)
      result = BatchChoose_result.new()
      begin
        result.success = @handler.batchChoose(args.batchChoiceRequest)
      rescue ::P13nServiceException => p13nServiceException
        result.p13nServiceException = p13nServiceException
      end
      write_result(result, oprot, 'batchChoose', seqid)
    end

    def process_autocomplete(seqid, iprot, oprot)
      args = read_args(iprot, Autocomplete_args)
      result = Autocomplete_result.new()
      begin
        result.success = @handler.autocomplete(args.request)
      rescue ::P13nServiceException => p13nServiceException
        result.p13nServiceException = p13nServiceException
      end
      write_result(result, oprot, 'autocomplete', seqid)
    end

  end

  # HELPER FUNCTIONS AND STRUCTURES

  class Choose_args
    include ::Thrift::Struct, ::Thrift::Struct_Union
    CHOICEREQUEST = -1

    FIELDS = {
      CHOICEREQUEST => {:type => ::Thrift::Types::STRUCT, :name => 'choiceRequest', :class => ::ChoiceRequest}
    }

    def struct_fields; FIELDS; end

    def validate
    end

    ::Thrift::Struct.generate_accessors self
  end

  class Choose_result
    include ::Thrift::Struct, ::Thrift::Struct_Union
    SUCCESS = 0
    P13NSERVICEEXCEPTION = 1

    FIELDS = {
      SUCCESS => {:type => ::Thrift::Types::STRUCT, :name => 'success', :class => ::ChoiceResponse},
      P13NSERVICEEXCEPTION => {:type => ::Thrift::Types::STRUCT, :name => 'p13nServiceException', :class => ::P13nServiceException}
    }

    def struct_fields; FIELDS; end

    def validate
    end

    ::Thrift::Struct.generate_accessors self
  end

  class BatchChoose_args
    include ::Thrift::Struct, ::Thrift::Struct_Union
    BATCHCHOICEREQUEST = -1

    FIELDS = {
      BATCHCHOICEREQUEST => {:type => ::Thrift::Types::STRUCT, :name => 'batchChoiceRequest', :class => ::BatchChoiceRequest}
    }

    def struct_fields; FIELDS; end

    def validate
    end

    ::Thrift::Struct.generate_accessors self
  end

  class BatchChoose_result
    include ::Thrift::Struct, ::Thrift::Struct_Union
    SUCCESS = 0
    P13NSERVICEEXCEPTION = 1

    FIELDS = {
      SUCCESS => {:type => ::Thrift::Types::STRUCT, :name => 'success', :class => ::BatchChoiceResponse},
      P13NSERVICEEXCEPTION => {:type => ::Thrift::Types::STRUCT, :name => 'p13nServiceException', :class => ::P13nServiceException}
    }

    def struct_fields; FIELDS; end

    def validate
    end

    ::Thrift::Struct.generate_accessors self
  end

  class Autocomplete_args
    include ::Thrift::Struct, ::Thrift::Struct_Union
    REQUEST = -1

    FIELDS = {
      REQUEST => {:type => ::Thrift::Types::STRUCT, :name => 'request', :class => ::AutocompleteRequest}
    }

    def struct_fields; FIELDS; end

    def validate
    end

    ::Thrift::Struct.generate_accessors self
  end

  class Autocomplete_result
    include ::Thrift::Struct, ::Thrift::Struct_Union
    SUCCESS = 0
    P13NSERVICEEXCEPTION = 1

    FIELDS = {
      SUCCESS => {:type => ::Thrift::Types::STRUCT, :name => 'success', :class => ::AutocompleteResponse},
      P13NSERVICEEXCEPTION => {:type => ::Thrift::Types::STRUCT, :name => 'p13nServiceException', :class => ::P13nServiceException}
    }

    def struct_fields; FIELDS; end

    def validate
    end

    ::Thrift::Struct.generate_accessors self
  end

end

