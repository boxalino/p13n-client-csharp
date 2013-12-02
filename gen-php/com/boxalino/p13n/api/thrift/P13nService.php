<?php
namespace com\boxalino\p13n\api\thrift;
/**
 * Autogenerated by Thrift Compiler (0.9.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
use Thrift\Base\TBase;
use Thrift\Type\TType;
use Thrift\Type\TMessageType;
use Thrift\Exception\TException;
use Thrift\Exception\TProtocolException;
use Thrift\Protocol\TProtocol;
use Thrift\Exception\TApplicationException;


interface P13nServiceIf {
  public function choose(\com\boxalino\p13n\api\thrift\ChoiceRequest $choiceRequest);
  public function uploadChoiceConfiguration($xmlPayload);
  public function saveProfileProperties($profilePropertyValues);
  public function command($command);
  public function batchChoose(\com\boxalino\p13n\api\thrift\BatchChoiceRequest $batchChoiceRequest);
}

class P13nServiceClient implements \com\boxalino\p13n\api\thrift\P13nServiceIf {
  protected $input_ = null;
  protected $output_ = null;

  protected $seqid_ = 0;

  public function __construct($input, $output=null) {
    $this->input_ = $input;
    $this->output_ = $output ? $output : $input;
  }

  public function choose(\com\boxalino\p13n\api\thrift\ChoiceRequest $choiceRequest)
  {
    $this->send_choose($choiceRequest);
    return $this->recv_choose();
  }

  public function send_choose(\com\boxalino\p13n\api\thrift\ChoiceRequest $choiceRequest)
  {
    $args = new \com\boxalino\p13n\api\thrift\P13nService_choose_args();
    $args->choiceRequest = $choiceRequest;
    $bin_accel = ($this->output_ instanceof TProtocol::$TBINARYPROTOCOLACCELERATED) && function_exists('thrift_protocol_write_binary');
    if ($bin_accel)
    {
      thrift_protocol_write_binary($this->output_, 'choose', TMessageType::CALL, $args, $this->seqid_, $this->output_->isStrictWrite());
    }
    else
    {
      $this->output_->writeMessageBegin('choose', TMessageType::CALL, $this->seqid_);
      $args->write($this->output_);
      $this->output_->writeMessageEnd();
      $this->output_->getTransport()->flush();
    }
  }

  public function recv_choose()
  {
    $bin_accel = ($this->input_ instanceof TProtocol::$TBINARYPROTOCOLACCELERATED) && function_exists('thrift_protocol_read_binary');
    if ($bin_accel) $result = thrift_protocol_read_binary($this->input_, '\com\boxalino\p13n\api\thrift\P13nService_choose_result', $this->input_->isStrictRead());
    else
    {
      $rseqid = 0;
      $fname = null;
      $mtype = 0;

      $this->input_->readMessageBegin($fname, $mtype, $rseqid);
      if ($mtype == TMessageType::EXCEPTION) {
        $x = new TApplicationException();
        $x->read($this->input_);
        $this->input_->readMessageEnd();
        throw $x;
      }
      $result = new \com\boxalino\p13n\api\thrift\P13nService_choose_result();
      $result->read($this->input_);
      $this->input_->readMessageEnd();
    }
    if ($result->success !== null) {
      return $result->success;
    }
    if ($result->p13ServiceException !== null) {
      throw $result->p13ServiceException;
    }
    throw new \Exception("choose failed: unknown result");
  }

  public function uploadChoiceConfiguration($xmlPayload)
  {
    $this->send_uploadChoiceConfiguration($xmlPayload);
    return $this->recv_uploadChoiceConfiguration();
  }

  public function send_uploadChoiceConfiguration($xmlPayload)
  {
    $args = new \com\boxalino\p13n\api\thrift\P13nService_uploadChoiceConfiguration_args();
    $args->xmlPayload = $xmlPayload;
    $bin_accel = ($this->output_ instanceof TProtocol::$TBINARYPROTOCOLACCELERATED) && function_exists('thrift_protocol_write_binary');
    if ($bin_accel)
    {
      thrift_protocol_write_binary($this->output_, 'uploadChoiceConfiguration', TMessageType::CALL, $args, $this->seqid_, $this->output_->isStrictWrite());
    }
    else
    {
      $this->output_->writeMessageBegin('uploadChoiceConfiguration', TMessageType::CALL, $this->seqid_);
      $args->write($this->output_);
      $this->output_->writeMessageEnd();
      $this->output_->getTransport()->flush();
    }
  }

  public function recv_uploadChoiceConfiguration()
  {
    $bin_accel = ($this->input_ instanceof TProtocol::$TBINARYPROTOCOLACCELERATED) && function_exists('thrift_protocol_read_binary');
    if ($bin_accel) $result = thrift_protocol_read_binary($this->input_, '\com\boxalino\p13n\api\thrift\P13nService_uploadChoiceConfiguration_result', $this->input_->isStrictRead());
    else
    {
      $rseqid = 0;
      $fname = null;
      $mtype = 0;

      $this->input_->readMessageBegin($fname, $mtype, $rseqid);
      if ($mtype == TMessageType::EXCEPTION) {
        $x = new TApplicationException();
        $x->read($this->input_);
        $this->input_->readMessageEnd();
        throw $x;
      }
      $result = new \com\boxalino\p13n\api\thrift\P13nService_uploadChoiceConfiguration_result();
      $result->read($this->input_);
      $this->input_->readMessageEnd();
    }
    if ($result->success !== null) {
      return $result->success;
    }
    if ($result->p13ServiceException !== null) {
      throw $result->p13ServiceException;
    }
    throw new \Exception("uploadChoiceConfiguration failed: unknown result");
  }

  public function saveProfileProperties($profilePropertyValues)
  {
    $this->send_saveProfileProperties($profilePropertyValues);
    return $this->recv_saveProfileProperties();
  }

  public function send_saveProfileProperties($profilePropertyValues)
  {
    $args = new \com\boxalino\p13n\api\thrift\P13nService_saveProfileProperties_args();
    $args->profilePropertyValues = $profilePropertyValues;
    $bin_accel = ($this->output_ instanceof TProtocol::$TBINARYPROTOCOLACCELERATED) && function_exists('thrift_protocol_write_binary');
    if ($bin_accel)
    {
      thrift_protocol_write_binary($this->output_, 'saveProfileProperties', TMessageType::CALL, $args, $this->seqid_, $this->output_->isStrictWrite());
    }
    else
    {
      $this->output_->writeMessageBegin('saveProfileProperties', TMessageType::CALL, $this->seqid_);
      $args->write($this->output_);
      $this->output_->writeMessageEnd();
      $this->output_->getTransport()->flush();
    }
  }

  public function recv_saveProfileProperties()
  {
    $bin_accel = ($this->input_ instanceof TProtocol::$TBINARYPROTOCOLACCELERATED) && function_exists('thrift_protocol_read_binary');
    if ($bin_accel) $result = thrift_protocol_read_binary($this->input_, '\com\boxalino\p13n\api\thrift\P13nService_saveProfileProperties_result', $this->input_->isStrictRead());
    else
    {
      $rseqid = 0;
      $fname = null;
      $mtype = 0;

      $this->input_->readMessageBegin($fname, $mtype, $rseqid);
      if ($mtype == TMessageType::EXCEPTION) {
        $x = new TApplicationException();
        $x->read($this->input_);
        $this->input_->readMessageEnd();
        throw $x;
      }
      $result = new \com\boxalino\p13n\api\thrift\P13nService_saveProfileProperties_result();
      $result->read($this->input_);
      $this->input_->readMessageEnd();
    }
    if ($result->success !== null) {
      return $result->success;
    }
    if ($result->p13ServiceException !== null) {
      throw $result->p13ServiceException;
    }
    throw new \Exception("saveProfileProperties failed: unknown result");
  }

  public function command($command)
  {
    $this->send_command($command);
    return $this->recv_command();
  }

  public function send_command($command)
  {
    $args = new \com\boxalino\p13n\api\thrift\P13nService_command_args();
    $args->command = $command;
    $bin_accel = ($this->output_ instanceof TProtocol::$TBINARYPROTOCOLACCELERATED) && function_exists('thrift_protocol_write_binary');
    if ($bin_accel)
    {
      thrift_protocol_write_binary($this->output_, 'command', TMessageType::CALL, $args, $this->seqid_, $this->output_->isStrictWrite());
    }
    else
    {
      $this->output_->writeMessageBegin('command', TMessageType::CALL, $this->seqid_);
      $args->write($this->output_);
      $this->output_->writeMessageEnd();
      $this->output_->getTransport()->flush();
    }
  }

  public function recv_command()
  {
    $bin_accel = ($this->input_ instanceof TProtocol::$TBINARYPROTOCOLACCELERATED) && function_exists('thrift_protocol_read_binary');
    if ($bin_accel) $result = thrift_protocol_read_binary($this->input_, '\com\boxalino\p13n\api\thrift\P13nService_command_result', $this->input_->isStrictRead());
    else
    {
      $rseqid = 0;
      $fname = null;
      $mtype = 0;

      $this->input_->readMessageBegin($fname, $mtype, $rseqid);
      if ($mtype == TMessageType::EXCEPTION) {
        $x = new TApplicationException();
        $x->read($this->input_);
        $this->input_->readMessageEnd();
        throw $x;
      }
      $result = new \com\boxalino\p13n\api\thrift\P13nService_command_result();
      $result->read($this->input_);
      $this->input_->readMessageEnd();
    }
    if ($result->success !== null) {
      return $result->success;
    }
    if ($result->p13ServiceException !== null) {
      throw $result->p13ServiceException;
    }
    throw new \Exception("command failed: unknown result");
  }

  public function batchChoose(\com\boxalino\p13n\api\thrift\BatchChoiceRequest $batchChoiceRequest)
  {
    $this->send_batchChoose($batchChoiceRequest);
    return $this->recv_batchChoose();
  }

  public function send_batchChoose(\com\boxalino\p13n\api\thrift\BatchChoiceRequest $batchChoiceRequest)
  {
    $args = new \com\boxalino\p13n\api\thrift\P13nService_batchChoose_args();
    $args->batchChoiceRequest = $batchChoiceRequest;
    $bin_accel = ($this->output_ instanceof TProtocol::$TBINARYPROTOCOLACCELERATED) && function_exists('thrift_protocol_write_binary');
    if ($bin_accel)
    {
      thrift_protocol_write_binary($this->output_, 'batchChoose', TMessageType::CALL, $args, $this->seqid_, $this->output_->isStrictWrite());
    }
    else
    {
      $this->output_->writeMessageBegin('batchChoose', TMessageType::CALL, $this->seqid_);
      $args->write($this->output_);
      $this->output_->writeMessageEnd();
      $this->output_->getTransport()->flush();
    }
  }

  public function recv_batchChoose()
  {
    $bin_accel = ($this->input_ instanceof TProtocol::$TBINARYPROTOCOLACCELERATED) && function_exists('thrift_protocol_read_binary');
    if ($bin_accel) $result = thrift_protocol_read_binary($this->input_, '\com\boxalino\p13n\api\thrift\P13nService_batchChoose_result', $this->input_->isStrictRead());
    else
    {
      $rseqid = 0;
      $fname = null;
      $mtype = 0;

      $this->input_->readMessageBegin($fname, $mtype, $rseqid);
      if ($mtype == TMessageType::EXCEPTION) {
        $x = new TApplicationException();
        $x->read($this->input_);
        $this->input_->readMessageEnd();
        throw $x;
      }
      $result = new \com\boxalino\p13n\api\thrift\P13nService_batchChoose_result();
      $result->read($this->input_);
      $this->input_->readMessageEnd();
    }
    if ($result->success !== null) {
      return $result->success;
    }
    if ($result->p13ServiceException !== null) {
      throw $result->p13ServiceException;
    }
    throw new \Exception("batchChoose failed: unknown result");
  }

}

// HELPER FUNCTIONS AND STRUCTURES

class P13nService_choose_args {
  static $_TSPEC;

  public $choiceRequest = null;

  public function __construct($vals=null) {
    if (!isset(self::$_TSPEC)) {
      self::$_TSPEC = array(
        -1 => array(
          'var' => 'choiceRequest',
          'type' => TType::STRUCT,
          'class' => '\com\boxalino\p13n\api\thrift\ChoiceRequest',
          ),
        );
    }
    if (is_array($vals)) {
      if (isset($vals['choiceRequest'])) {
        $this->choiceRequest = $vals['choiceRequest'];
      }
    }
  }

  public function getName() {
    return 'P13nService_choose_args';
  }

  public function read($input)
  {
    $xfer = 0;
    $fname = null;
    $ftype = 0;
    $fid = 0;
    $xfer += $input->readStructBegin($fname);
    while (true)
    {
      $xfer += $input->readFieldBegin($fname, $ftype, $fid);
      if ($ftype == TType::STOP) {
        break;
      }
      switch ($fid)
      {
        case -1:
          if ($ftype == TType::STRUCT) {
            $this->choiceRequest = new \com\boxalino\p13n\api\thrift\ChoiceRequest();
            $xfer += $this->choiceRequest->read($input);
          } else {
            $xfer += $input->skip($ftype);
          }
          break;
        default:
          $xfer += $input->skip($ftype);
          break;
      }
      $xfer += $input->readFieldEnd();
    }
    $xfer += $input->readStructEnd();
    return $xfer;
  }

  public function write($output) {
    $xfer = 0;
    $xfer += $output->writeStructBegin('P13nService_choose_args');
    if ($this->choiceRequest !== null) {
      if (!is_object($this->choiceRequest)) {
        throw new TProtocolException('Bad type in structure.', TProtocolException::INVALID_DATA);
      }
      $xfer += $output->writeFieldBegin('choiceRequest', TType::STRUCT, -1);
      $xfer += $this->choiceRequest->write($output);
      $xfer += $output->writeFieldEnd();
    }
    $xfer += $output->writeFieldStop();
    $xfer += $output->writeStructEnd();
    return $xfer;
  }

}

class P13nService_choose_result {
  static $_TSPEC;

  public $success = null;
  public $p13ServiceException = null;

  public function __construct($vals=null) {
    if (!isset(self::$_TSPEC)) {
      self::$_TSPEC = array(
        0 => array(
          'var' => 'success',
          'type' => TType::STRUCT,
          'class' => '\com\boxalino\p13n\api\thrift\ChoiceResponse',
          ),
        1 => array(
          'var' => 'p13ServiceException',
          'type' => TType::STRUCT,
          'class' => '\com\boxalino\p13n\api\thrift\P13ServiceException',
          ),
        );
    }
    if (is_array($vals)) {
      if (isset($vals['success'])) {
        $this->success = $vals['success'];
      }
      if (isset($vals['p13ServiceException'])) {
        $this->p13ServiceException = $vals['p13ServiceException'];
      }
    }
  }

  public function getName() {
    return 'P13nService_choose_result';
  }

  public function read($input)
  {
    $xfer = 0;
    $fname = null;
    $ftype = 0;
    $fid = 0;
    $xfer += $input->readStructBegin($fname);
    while (true)
    {
      $xfer += $input->readFieldBegin($fname, $ftype, $fid);
      if ($ftype == TType::STOP) {
        break;
      }
      switch ($fid)
      {
        case 0:
          if ($ftype == TType::STRUCT) {
            $this->success = new \com\boxalino\p13n\api\thrift\ChoiceResponse();
            $xfer += $this->success->read($input);
          } else {
            $xfer += $input->skip($ftype);
          }
          break;
        case 1:
          if ($ftype == TType::STRUCT) {
            $this->p13ServiceException = new \com\boxalino\p13n\api\thrift\P13ServiceException();
            $xfer += $this->p13ServiceException->read($input);
          } else {
            $xfer += $input->skip($ftype);
          }
          break;
        default:
          $xfer += $input->skip($ftype);
          break;
      }
      $xfer += $input->readFieldEnd();
    }
    $xfer += $input->readStructEnd();
    return $xfer;
  }

  public function write($output) {
    $xfer = 0;
    $xfer += $output->writeStructBegin('P13nService_choose_result');
    if ($this->success !== null) {
      if (!is_object($this->success)) {
        throw new TProtocolException('Bad type in structure.', TProtocolException::INVALID_DATA);
      }
      $xfer += $output->writeFieldBegin('success', TType::STRUCT, 0);
      $xfer += $this->success->write($output);
      $xfer += $output->writeFieldEnd();
    }
    if ($this->p13ServiceException !== null) {
      $xfer += $output->writeFieldBegin('p13ServiceException', TType::STRUCT, 1);
      $xfer += $this->p13ServiceException->write($output);
      $xfer += $output->writeFieldEnd();
    }
    $xfer += $output->writeFieldStop();
    $xfer += $output->writeStructEnd();
    return $xfer;
  }

}

class P13nService_uploadChoiceConfiguration_args {
  static $_TSPEC;

  public $xmlPayload = null;

  public function __construct($vals=null) {
    if (!isset(self::$_TSPEC)) {
      self::$_TSPEC = array(
        -1 => array(
          'var' => 'xmlPayload',
          'type' => TType::STRING,
          ),
        );
    }
    if (is_array($vals)) {
      if (isset($vals['xmlPayload'])) {
        $this->xmlPayload = $vals['xmlPayload'];
      }
    }
  }

  public function getName() {
    return 'P13nService_uploadChoiceConfiguration_args';
  }

  public function read($input)
  {
    $xfer = 0;
    $fname = null;
    $ftype = 0;
    $fid = 0;
    $xfer += $input->readStructBegin($fname);
    while (true)
    {
      $xfer += $input->readFieldBegin($fname, $ftype, $fid);
      if ($ftype == TType::STOP) {
        break;
      }
      switch ($fid)
      {
        case -1:
          if ($ftype == TType::STRING) {
            $xfer += $input->readString($this->xmlPayload);
          } else {
            $xfer += $input->skip($ftype);
          }
          break;
        default:
          $xfer += $input->skip($ftype);
          break;
      }
      $xfer += $input->readFieldEnd();
    }
    $xfer += $input->readStructEnd();
    return $xfer;
  }

  public function write($output) {
    $xfer = 0;
    $xfer += $output->writeStructBegin('P13nService_uploadChoiceConfiguration_args');
    if ($this->xmlPayload !== null) {
      $xfer += $output->writeFieldBegin('xmlPayload', TType::STRING, -1);
      $xfer += $output->writeString($this->xmlPayload);
      $xfer += $output->writeFieldEnd();
    }
    $xfer += $output->writeFieldStop();
    $xfer += $output->writeStructEnd();
    return $xfer;
  }

}

class P13nService_uploadChoiceConfiguration_result {
  static $_TSPEC;

  public $success = null;
  public $p13ServiceException = null;

  public function __construct($vals=null) {
    if (!isset(self::$_TSPEC)) {
      self::$_TSPEC = array(
        0 => array(
          'var' => 'success',
          'type' => TType::STRING,
          ),
        1 => array(
          'var' => 'p13ServiceException',
          'type' => TType::STRUCT,
          'class' => '\com\boxalino\p13n\api\thrift\P13ServiceException',
          ),
        );
    }
    if (is_array($vals)) {
      if (isset($vals['success'])) {
        $this->success = $vals['success'];
      }
      if (isset($vals['p13ServiceException'])) {
        $this->p13ServiceException = $vals['p13ServiceException'];
      }
    }
  }

  public function getName() {
    return 'P13nService_uploadChoiceConfiguration_result';
  }

  public function read($input)
  {
    $xfer = 0;
    $fname = null;
    $ftype = 0;
    $fid = 0;
    $xfer += $input->readStructBegin($fname);
    while (true)
    {
      $xfer += $input->readFieldBegin($fname, $ftype, $fid);
      if ($ftype == TType::STOP) {
        break;
      }
      switch ($fid)
      {
        case 0:
          if ($ftype == TType::STRING) {
            $xfer += $input->readString($this->success);
          } else {
            $xfer += $input->skip($ftype);
          }
          break;
        case 1:
          if ($ftype == TType::STRUCT) {
            $this->p13ServiceException = new \com\boxalino\p13n\api\thrift\P13ServiceException();
            $xfer += $this->p13ServiceException->read($input);
          } else {
            $xfer += $input->skip($ftype);
          }
          break;
        default:
          $xfer += $input->skip($ftype);
          break;
      }
      $xfer += $input->readFieldEnd();
    }
    $xfer += $input->readStructEnd();
    return $xfer;
  }

  public function write($output) {
    $xfer = 0;
    $xfer += $output->writeStructBegin('P13nService_uploadChoiceConfiguration_result');
    if ($this->success !== null) {
      $xfer += $output->writeFieldBegin('success', TType::STRING, 0);
      $xfer += $output->writeString($this->success);
      $xfer += $output->writeFieldEnd();
    }
    if ($this->p13ServiceException !== null) {
      $xfer += $output->writeFieldBegin('p13ServiceException', TType::STRUCT, 1);
      $xfer += $this->p13ServiceException->write($output);
      $xfer += $output->writeFieldEnd();
    }
    $xfer += $output->writeFieldStop();
    $xfer += $output->writeStructEnd();
    return $xfer;
  }

}

class P13nService_saveProfileProperties_args {
  static $_TSPEC;

  public $profilePropertyValues = null;

  public function __construct($vals=null) {
    if (!isset(self::$_TSPEC)) {
      self::$_TSPEC = array(
        -1 => array(
          'var' => 'profilePropertyValues',
          'type' => TType::LST,
          'etype' => TType::STRUCT,
          'elem' => array(
            'type' => TType::STRUCT,
            'class' => '\com\boxalino\p13n\api\thrift\ProfilePropertyValue',
            ),
          ),
        );
    }
    if (is_array($vals)) {
      if (isset($vals['profilePropertyValues'])) {
        $this->profilePropertyValues = $vals['profilePropertyValues'];
      }
    }
  }

  public function getName() {
    return 'P13nService_saveProfileProperties_args';
  }

  public function read($input)
  {
    $xfer = 0;
    $fname = null;
    $ftype = 0;
    $fid = 0;
    $xfer += $input->readStructBegin($fname);
    while (true)
    {
      $xfer += $input->readFieldBegin($fname, $ftype, $fid);
      if ($ftype == TType::STOP) {
        break;
      }
      switch ($fid)
      {
        case -1:
          if ($ftype == TType::LST) {
            $this->profilePropertyValues = array();
            $_size139 = 0;
            $_etype142 = 0;
            $xfer += $input->readListBegin($_etype142, $_size139);
            for ($_i143 = 0; $_i143 < $_size139; ++$_i143)
            {
              $elem144 = null;
              $elem144 = new \com\boxalino\p13n\api\thrift\ProfilePropertyValue();
              $xfer += $elem144->read($input);
              $this->profilePropertyValues []= $elem144;
            }
            $xfer += $input->readListEnd();
          } else {
            $xfer += $input->skip($ftype);
          }
          break;
        default:
          $xfer += $input->skip($ftype);
          break;
      }
      $xfer += $input->readFieldEnd();
    }
    $xfer += $input->readStructEnd();
    return $xfer;
  }

  public function write($output) {
    $xfer = 0;
    $xfer += $output->writeStructBegin('P13nService_saveProfileProperties_args');
    if ($this->profilePropertyValues !== null) {
      if (!is_array($this->profilePropertyValues)) {
        throw new TProtocolException('Bad type in structure.', TProtocolException::INVALID_DATA);
      }
      $xfer += $output->writeFieldBegin('profilePropertyValues', TType::LST, -1);
      {
        $output->writeListBegin(TType::STRUCT, count($this->profilePropertyValues));
        {
          foreach ($this->profilePropertyValues as $iter145)
          {
            $xfer += $iter145->write($output);
          }
        }
        $output->writeListEnd();
      }
      $xfer += $output->writeFieldEnd();
    }
    $xfer += $output->writeFieldStop();
    $xfer += $output->writeStructEnd();
    return $xfer;
  }

}

class P13nService_saveProfileProperties_result {
  static $_TSPEC;

  public $success = null;
  public $p13ServiceException = null;

  public function __construct($vals=null) {
    if (!isset(self::$_TSPEC)) {
      self::$_TSPEC = array(
        0 => array(
          'var' => 'success',
          'type' => TType::I32,
          ),
        1 => array(
          'var' => 'p13ServiceException',
          'type' => TType::STRUCT,
          'class' => '\com\boxalino\p13n\api\thrift\P13ServiceException',
          ),
        );
    }
    if (is_array($vals)) {
      if (isset($vals['success'])) {
        $this->success = $vals['success'];
      }
      if (isset($vals['p13ServiceException'])) {
        $this->p13ServiceException = $vals['p13ServiceException'];
      }
    }
  }

  public function getName() {
    return 'P13nService_saveProfileProperties_result';
  }

  public function read($input)
  {
    $xfer = 0;
    $fname = null;
    $ftype = 0;
    $fid = 0;
    $xfer += $input->readStructBegin($fname);
    while (true)
    {
      $xfer += $input->readFieldBegin($fname, $ftype, $fid);
      if ($ftype == TType::STOP) {
        break;
      }
      switch ($fid)
      {
        case 0:
          if ($ftype == TType::I32) {
            $xfer += $input->readI32($this->success);
          } else {
            $xfer += $input->skip($ftype);
          }
          break;
        case 1:
          if ($ftype == TType::STRUCT) {
            $this->p13ServiceException = new \com\boxalino\p13n\api\thrift\P13ServiceException();
            $xfer += $this->p13ServiceException->read($input);
          } else {
            $xfer += $input->skip($ftype);
          }
          break;
        default:
          $xfer += $input->skip($ftype);
          break;
      }
      $xfer += $input->readFieldEnd();
    }
    $xfer += $input->readStructEnd();
    return $xfer;
  }

  public function write($output) {
    $xfer = 0;
    $xfer += $output->writeStructBegin('P13nService_saveProfileProperties_result');
    if ($this->success !== null) {
      $xfer += $output->writeFieldBegin('success', TType::I32, 0);
      $xfer += $output->writeI32($this->success);
      $xfer += $output->writeFieldEnd();
    }
    if ($this->p13ServiceException !== null) {
      $xfer += $output->writeFieldBegin('p13ServiceException', TType::STRUCT, 1);
      $xfer += $this->p13ServiceException->write($output);
      $xfer += $output->writeFieldEnd();
    }
    $xfer += $output->writeFieldStop();
    $xfer += $output->writeStructEnd();
    return $xfer;
  }

}

class P13nService_command_args {
  static $_TSPEC;

  public $command = null;

  public function __construct($vals=null) {
    if (!isset(self::$_TSPEC)) {
      self::$_TSPEC = array(
        -1 => array(
          'var' => 'command',
          'type' => TType::STRING,
          ),
        );
    }
    if (is_array($vals)) {
      if (isset($vals['command'])) {
        $this->command = $vals['command'];
      }
    }
  }

  public function getName() {
    return 'P13nService_command_args';
  }

  public function read($input)
  {
    $xfer = 0;
    $fname = null;
    $ftype = 0;
    $fid = 0;
    $xfer += $input->readStructBegin($fname);
    while (true)
    {
      $xfer += $input->readFieldBegin($fname, $ftype, $fid);
      if ($ftype == TType::STOP) {
        break;
      }
      switch ($fid)
      {
        case -1:
          if ($ftype == TType::STRING) {
            $xfer += $input->readString($this->command);
          } else {
            $xfer += $input->skip($ftype);
          }
          break;
        default:
          $xfer += $input->skip($ftype);
          break;
      }
      $xfer += $input->readFieldEnd();
    }
    $xfer += $input->readStructEnd();
    return $xfer;
  }

  public function write($output) {
    $xfer = 0;
    $xfer += $output->writeStructBegin('P13nService_command_args');
    if ($this->command !== null) {
      $xfer += $output->writeFieldBegin('command', TType::STRING, -1);
      $xfer += $output->writeString($this->command);
      $xfer += $output->writeFieldEnd();
    }
    $xfer += $output->writeFieldStop();
    $xfer += $output->writeStructEnd();
    return $xfer;
  }

}

class P13nService_command_result {
  static $_TSPEC;

  public $success = null;
  public $p13ServiceException = null;

  public function __construct($vals=null) {
    if (!isset(self::$_TSPEC)) {
      self::$_TSPEC = array(
        0 => array(
          'var' => 'success',
          'type' => TType::STRING,
          ),
        1 => array(
          'var' => 'p13ServiceException',
          'type' => TType::STRUCT,
          'class' => '\com\boxalino\p13n\api\thrift\P13ServiceException',
          ),
        );
    }
    if (is_array($vals)) {
      if (isset($vals['success'])) {
        $this->success = $vals['success'];
      }
      if (isset($vals['p13ServiceException'])) {
        $this->p13ServiceException = $vals['p13ServiceException'];
      }
    }
  }

  public function getName() {
    return 'P13nService_command_result';
  }

  public function read($input)
  {
    $xfer = 0;
    $fname = null;
    $ftype = 0;
    $fid = 0;
    $xfer += $input->readStructBegin($fname);
    while (true)
    {
      $xfer += $input->readFieldBegin($fname, $ftype, $fid);
      if ($ftype == TType::STOP) {
        break;
      }
      switch ($fid)
      {
        case 0:
          if ($ftype == TType::STRING) {
            $xfer += $input->readString($this->success);
          } else {
            $xfer += $input->skip($ftype);
          }
          break;
        case 1:
          if ($ftype == TType::STRUCT) {
            $this->p13ServiceException = new \com\boxalino\p13n\api\thrift\P13ServiceException();
            $xfer += $this->p13ServiceException->read($input);
          } else {
            $xfer += $input->skip($ftype);
          }
          break;
        default:
          $xfer += $input->skip($ftype);
          break;
      }
      $xfer += $input->readFieldEnd();
    }
    $xfer += $input->readStructEnd();
    return $xfer;
  }

  public function write($output) {
    $xfer = 0;
    $xfer += $output->writeStructBegin('P13nService_command_result');
    if ($this->success !== null) {
      $xfer += $output->writeFieldBegin('success', TType::STRING, 0);
      $xfer += $output->writeString($this->success);
      $xfer += $output->writeFieldEnd();
    }
    if ($this->p13ServiceException !== null) {
      $xfer += $output->writeFieldBegin('p13ServiceException', TType::STRUCT, 1);
      $xfer += $this->p13ServiceException->write($output);
      $xfer += $output->writeFieldEnd();
    }
    $xfer += $output->writeFieldStop();
    $xfer += $output->writeStructEnd();
    return $xfer;
  }

}

class P13nService_batchChoose_args {
  static $_TSPEC;

  public $batchChoiceRequest = null;

  public function __construct($vals=null) {
    if (!isset(self::$_TSPEC)) {
      self::$_TSPEC = array(
        -1 => array(
          'var' => 'batchChoiceRequest',
          'type' => TType::STRUCT,
          'class' => '\com\boxalino\p13n\api\thrift\BatchChoiceRequest',
          ),
        );
    }
    if (is_array($vals)) {
      if (isset($vals['batchChoiceRequest'])) {
        $this->batchChoiceRequest = $vals['batchChoiceRequest'];
      }
    }
  }

  public function getName() {
    return 'P13nService_batchChoose_args';
  }

  public function read($input)
  {
    $xfer = 0;
    $fname = null;
    $ftype = 0;
    $fid = 0;
    $xfer += $input->readStructBegin($fname);
    while (true)
    {
      $xfer += $input->readFieldBegin($fname, $ftype, $fid);
      if ($ftype == TType::STOP) {
        break;
      }
      switch ($fid)
      {
        case -1:
          if ($ftype == TType::STRUCT) {
            $this->batchChoiceRequest = new \com\boxalino\p13n\api\thrift\BatchChoiceRequest();
            $xfer += $this->batchChoiceRequest->read($input);
          } else {
            $xfer += $input->skip($ftype);
          }
          break;
        default:
          $xfer += $input->skip($ftype);
          break;
      }
      $xfer += $input->readFieldEnd();
    }
    $xfer += $input->readStructEnd();
    return $xfer;
  }

  public function write($output) {
    $xfer = 0;
    $xfer += $output->writeStructBegin('P13nService_batchChoose_args');
    if ($this->batchChoiceRequest !== null) {
      if (!is_object($this->batchChoiceRequest)) {
        throw new TProtocolException('Bad type in structure.', TProtocolException::INVALID_DATA);
      }
      $xfer += $output->writeFieldBegin('batchChoiceRequest', TType::STRUCT, -1);
      $xfer += $this->batchChoiceRequest->write($output);
      $xfer += $output->writeFieldEnd();
    }
    $xfer += $output->writeFieldStop();
    $xfer += $output->writeStructEnd();
    return $xfer;
  }

}

class P13nService_batchChoose_result {
  static $_TSPEC;

  public $success = null;
  public $p13ServiceException = null;

  public function __construct($vals=null) {
    if (!isset(self::$_TSPEC)) {
      self::$_TSPEC = array(
        0 => array(
          'var' => 'success',
          'type' => TType::STRUCT,
          'class' => '\com\boxalino\p13n\api\thrift\BatchChoiceResponse',
          ),
        1 => array(
          'var' => 'p13ServiceException',
          'type' => TType::STRUCT,
          'class' => '\com\boxalino\p13n\api\thrift\P13ServiceException',
          ),
        );
    }
    if (is_array($vals)) {
      if (isset($vals['success'])) {
        $this->success = $vals['success'];
      }
      if (isset($vals['p13ServiceException'])) {
        $this->p13ServiceException = $vals['p13ServiceException'];
      }
    }
  }

  public function getName() {
    return 'P13nService_batchChoose_result';
  }

  public function read($input)
  {
    $xfer = 0;
    $fname = null;
    $ftype = 0;
    $fid = 0;
    $xfer += $input->readStructBegin($fname);
    while (true)
    {
      $xfer += $input->readFieldBegin($fname, $ftype, $fid);
      if ($ftype == TType::STOP) {
        break;
      }
      switch ($fid)
      {
        case 0:
          if ($ftype == TType::STRUCT) {
            $this->success = new \com\boxalino\p13n\api\thrift\BatchChoiceResponse();
            $xfer += $this->success->read($input);
          } else {
            $xfer += $input->skip($ftype);
          }
          break;
        case 1:
          if ($ftype == TType::STRUCT) {
            $this->p13ServiceException = new \com\boxalino\p13n\api\thrift\P13ServiceException();
            $xfer += $this->p13ServiceException->read($input);
          } else {
            $xfer += $input->skip($ftype);
          }
          break;
        default:
          $xfer += $input->skip($ftype);
          break;
      }
      $xfer += $input->readFieldEnd();
    }
    $xfer += $input->readStructEnd();
    return $xfer;
  }

  public function write($output) {
    $xfer = 0;
    $xfer += $output->writeStructBegin('P13nService_batchChoose_result');
    if ($this->success !== null) {
      if (!is_object($this->success)) {
        throw new TProtocolException('Bad type in structure.', TProtocolException::INVALID_DATA);
      }
      $xfer += $output->writeFieldBegin('success', TType::STRUCT, 0);
      $xfer += $this->success->write($output);
      $xfer += $output->writeFieldEnd();
    }
    if ($this->p13ServiceException !== null) {
      $xfer += $output->writeFieldBegin('p13ServiceException', TType::STRUCT, 1);
      $xfer += $this->p13ServiceException->write($output);
      $xfer += $output->writeFieldEnd();
    }
    $xfer += $output->writeFieldStop();
    $xfer += $output->writeStructEnd();
    return $xfer;
  }

}


